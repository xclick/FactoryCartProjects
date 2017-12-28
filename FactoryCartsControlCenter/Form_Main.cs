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

namespace FactoryCartsControlCenter
{
    public partial class Form_Main : Form
    {
        private MqttClientService mqttService;
        private BindingList<CartInfo> cartList;
        private Dictionary<string, CartInfo> cartMap;

        private string mqttClientId;
        Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form_Main()
        {
            InitializeComponent();

            this.mqttClientId = Guid.NewGuid().ToString();

            this.mqttService = new MqttClientService(
                this.config.AppSettings.Settings["BrokerAddr"].Value,
                MqttClientLibrary.Utils.OToInteger(this.config.AppSettings.Settings["BrokerPort"].Value),
                this.config.AppSettings.Settings["BrokerUserName"].Value,
                this.config.AppSettings.Settings["BrokerPassword"].Value,
                this.mqttClientId);

            this.mqttService.OnMqttClientServiceMessageRecieved += new MqttClientLibrary.MqttClientServiceMessageRecieved(this.MqttClientServiceMessageRecieved);

            this.cartList = new BindingList<CartInfo>();
            this.cartMap = new Dictionary<string, CartInfo>();
            this.refreshCartList();
        }

        private void buttonRequestCartInfo_Click(object sender, EventArgs e)
        {
            this.cartList.Clear();
            this.cartMap.Clear();
            this.mqttService.SendCartInfoRequest();
        }

        private void MqttClientServiceMessageRecieved(string topic, string message)
        {
            this.OutputLog(topic + ":" + message);

            if (topic == Constants.TOPIC_CART_INFO)
            {
                if (!String.IsNullOrEmpty(message))
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        CartInfo cartInfo = new CartInfo();
                        cartInfo.fromPayload(message);
                        if (!this.cartMap.ContainsKey(cartInfo.Id))
                        {
                            this.cartList.Add(cartInfo);
                            this.cartMap[cartInfo.Id] = cartInfo;
                        }else
                        {
                            for (int i = 0; i < this.cartList.Count; i++)
                            {
                                if (this.cartList[i].Id == cartInfo.Id)
                                {
                                    this.cartList[i].Status = cartInfo.Status;
                                }
                            }
                        }
                        this.refreshCartList();
                    });
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

        private void refreshCartList()
        {
            this.dataGridViewCartList.AutoGenerateColumns = true;
            this.dataGridViewCartList.ReadOnly = true;
            this.dataGridViewCartList.RowHeadersVisible = false;
            this.dataGridViewCartList.AllowUserToAddRows = false;
            this.dataGridViewCartList.DataSource = new Dictionary<string, CartInfo>();

            this.dataGridViewCartList.DataSource = this.cartList;

            Utils.UIUtils.SetColumn(this.dataGridViewCartList, "Status", "", 30, true);
            Utils.UIUtils.SetColumn(this.dataGridViewCartList, "Id", "小车编号", 0, false);
            Utils.UIUtils.SetColumn(this.dataGridViewCartList, "Name", "小车名称", 240, true);
            
        }

        private void buttonTurnOnLight_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCartList.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewCartList.SelectedRows[0];
                string id = MqttClientLibrary.Utils.OToString(row.Cells["id"].Value);
                this.mqttService.SendTurnOnLightRequest(id);
            }
        }

        private void dataGridViewCartList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((this.dataGridViewCartList.Columns[e.ColumnIndex].Name.ToUpper() == "STATUS"))
            {
                if (e.Value != null)
                {
                    string v = e.Value.ToString();
                    if ("Y" == v.ToUpper())
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.SelectionBackColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;

                    }
                    else
                    {
                        e.CellStyle.ForeColor = SystemColors.Control;
                        e.CellStyle.BackColor = SystemColors.Control;
                        e.CellStyle.SelectionBackColor = SystemColors.Control;
                        e.CellStyle.SelectionForeColor = SystemColors.Control;
                    }
                }
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mqttService.Close();
        }
    }
}
