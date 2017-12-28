using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClientLibrary
{
    public class Constants
    {
        // 订阅的所有相关消息
        public const string TOPIC_CART_ALL = "factory/cart/#";
        // 请求小车列表
        public const string TOPIC_CART_INFO_REQUEST = "factory/cart/info/request";
        // 小车信息
        public const string TOPIC_CART_INFO = "factory/cart/info";
        // 小车发送PING命令
        public const string TOPIC_CART_PING = "factory/cart/ping";
        // 请求小车发声
        public const string TOPIC_CART_TURNONLIGHT_REQUEST = "factory/cart/turnonlight/request";
    }
}
