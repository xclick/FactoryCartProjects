using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClientLibrary
{
    public class Utils
    {
        #region Convert 
        public static string OToString(object o)
        {
            string result = "";
            if (o != null && !Convert.IsDBNull(o) && o.ToString() != "")
                result = o.ToString();
            return result;
        }

        public static int OToInteger(object o)
        {
            int result = 0;
            if (o != null && !Convert.IsDBNull(o) && o.ToString() != "")
                result = Int32.Parse(o.ToString());
            return result;
        }

        public static DateTime OToDateTime(object o, DateTime defaultValue)
        {
            DateTime result = defaultValue;
            if (o != null && !Convert.IsDBNull(o) && o.ToString() != "" && o.ToString() != "-")
                result = DateTime.Parse(o.ToString());
            return result;
        }

        public static DateTime OToDateTime(object o)
        {
            return OToDateTime(o, DateTime.MinValue);
        }

        public static double OToDouble(object o)
        {
            double result = 0;
            if (o != null && !Convert.IsDBNull(o) && o.ToString() != "")
                result = Double.Parse(o.ToString());
            return result;
        }
        #endregion
    }
}
