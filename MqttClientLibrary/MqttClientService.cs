using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqttClientLibrary
{
    public class MqttClientService
    {
        private MqttClient client;
        private string clientId;
        private string brokerAddr = "192.168.0.36";
        private int brokerPort = 61613;
        private string userName = "";
        public string password = "";

        private string[] topics = new string[]
        {
            Constants.TOPIC_CART_ALL
        };


        public event MqttClientServiceMessageRecieved OnMqttClientServiceMessageRecieved;

        public MqttClientService(string brokerAddr, int brokerPort, string userName, string password, string clientId)
        {
            this.brokerAddr = brokerAddr;
            this.brokerPort = brokerPort;
            this.userName = userName;
            this.password = password;
            this.clientId = clientId;

            this.client = new MqttClient(this.brokerAddr, this.brokerPort, false, null, null, MqttSslProtocols.None);
            this.client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            this.client.Connect(this.clientId, this.userName, this.password);
            this.client.Subscribe(topics,
                new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string recievedMessage = Encoding.UTF8.GetString(e.Message);
            string topic = e.Topic;
            if (this.OnMqttClientServiceMessageRecieved != null) OnMqttClientServiceMessageRecieved(topic, recievedMessage);
        }

        public void SendCartInfoRequest()
        {
            this.Publish(Constants.TOPIC_CART_INFO_REQUEST,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }

        public void SendCartInfo(CartInfo cartInfo)
        {
            string cardInfoPayload = cartInfo.toPayload();
            this.Publish(Constants.TOPIC_CART_INFO, cardInfoPayload);
        }

        public void SendTurnOnLightRequest(string cartId)
        {
            this.Publish(Constants.TOPIC_CART_TURNONLIGHT_REQUEST, cartId);
        }

        private bool Publish(string topic, string message)
        {
            if (String.IsNullOrEmpty(topic)) return false;
            string msg = (String.IsNullOrEmpty(message) ? "EMPTY" : message);
            this.client.Publish(topic, Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            return true;
        }

        public void Close()
        {
            if (this.client != null)
            {
                this.client.Unsubscribe(topics);
                this.client.Disconnect();
            }
        }
    }

    public delegate void MqttClientServiceMessageRecieved(string topic, string message);
}
