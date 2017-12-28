using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClientLibrary
{
    public class CartInfo
    {
        public string Status { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        

        public string toString()
        {
            return "Cart:{Id=" + Id + ", Name=" + Name + ", Status=" + Status+"}";
        }

        public string toPayload()
        {
            return Id + "|" + Name+"|"+Status;
        }

        public void fromPayload(string payload)
        {
            string[] ss = payload.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            if (ss.Length > 0) Id = ss[0];
            if (ss.Length > 1) Name = ss[1];
            if (ss.Length > 2) Status = ss[2];
        }
    }
}
