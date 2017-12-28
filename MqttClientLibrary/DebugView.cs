using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MqttClientLibrary
{
    /// <summary>
    /// DebugView Output Log message to debugview application
    /// DebugView.InstanceTag = " You Application Name";
    /// DebugView.Error("...");
    /// </summary>
    public class DebugView
    {
        public static string InstanceTag = "Undefined";

        [DllImport("kernel32")]
        private static extern int OutputDebugString(string msg);

        private static void Output(string msg)
        {
            OutputDebugString(String.Format("[{0}]{1}", InstanceTag, msg));
        }

        public static void Error(string msg)
        {
            string m = "ERROR:" + msg;
            Output(m);
        }

        public static void Info(string msg)
        {
            string m = " INFO:" + msg;
            Output(m);
        }

        public static void Warn(string msg)
        {
            string m = " WARN:" + msg;
            Output(m);
        }
    }
}
