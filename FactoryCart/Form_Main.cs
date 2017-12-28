using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MqttClientLibrary;

namespace FactoryCart
{
    public partial class Form_Main : Form
    {
        private MqttClientService mqttService;
        private string mqttClientId;
        Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form_Main()
        {
            InitializeComponent();

            this.mqttClientId = Guid.NewGuid().ToString();

            this.mqttService = new MqttClientService(
                this.config.AppSettings.Settings["BrokerAddr"].Value,
                Utils.OToInteger(this.config.AppSettings.Settings["BrokerPort"].Value),
                this.config.AppSettings.Settings["BrokerUserName"].Value,
                this.config.AppSettings.Settings["BrokerPassword"].Value,
                this.mqttClientId);

            this.mqttService.OnMqttClientServiceMessageRecieved += new MqttClientLibrary.MqttClientServiceMessageRecieved(this.MqttClientServiceMessageRecieved);

            this.checkBoxLightON.Checked = false;
            this.RefreshLightOn();
            this.textBoxCartName.ReadOnly = true;
            this.textBoxCartName.Text = this.config.AppSettings.Settings["CartName"].Value;

        }

        private void MqttClientServiceMessageRecieved(string topic, string message)
        {
            this.OutputLog(topic + ":" + message);

            if (topic == Constants.TOPIC_CART_INFO_REQUEST)
            {
                this.buttonPublishStatus.PerformClick();
                /*
                CartInfo cartInfo = new CartInfo();
                cartInfo.Id = this.config.AppSettings.Settings["CartId"].Value;
                cartInfo.Name = this.textBoxCartName.Text;
                cartInfo.Status = (this.checkBoxLightON.Checked ? "Y" : "N");
                this.mqttService.SendCartInfo(cartInfo);
                */
            }
            else if (topic == Constants.TOPIC_CART_TURNONLIGHT_REQUEST)
            {
                if (message == this.config.AppSettings.Settings["CartId"].Value)
                {
                    checkBoxLightON.Checked = true;
                    this.RefreshLightOn();
                    this.buttonPublishStatus.PerformClick();
                }

            }
        }

        private void OutputLog(string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                textBoxLog.Text += DateTime.Now.ToString("HH:mm:ss.fff") + ":" + message + Environment.NewLine;
                textBoxLog.Select(textBoxLog.Text.Length, 1);
                textBoxLog.ScrollToCaret();
            });
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mqttService.Close();
        }

        private void RefreshLightOn()
        {
            if (this.checkBoxLightON.Checked)
            {
                this.checkBoxLightON.Text = "灯亮";
                this.checkBoxLightON.BackColor = Color.Red;
            }
            else
            {
                this.checkBoxLightON.Text = "灯灭";
                this.checkBoxLightON.BackColor = SystemColors.Control;
            }
        }

        private void buttonPublishStatus_Click(object sender, EventArgs e)
        {
            CartInfo cartInfo = new CartInfo();
            cartInfo.Id = this.config.AppSettings.Settings["CartId"].Value;
            cartInfo.Name = this.textBoxCartName.Text;
            cartInfo.Status = (this.checkBoxLightON.Checked ? "Y" : "N");
            this.mqttService.SendCartInfo(cartInfo);
        }

        private void checkBoxLightON_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshLightOn();
            this.buttonPublishStatus.PerformClick();
        }
    }

}