using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotiChannelDemo.Constants
{
    internal class NotificationConstant
    {
        private NotificationConstant() { }

        public static readonly string BACKED_CHANNEL = "BE";
        public static readonly string FRONTENT_CHANNEL = "FE";
        public static readonly string QA_CHANNEL = "QA";
        public static readonly string URGENT_CHANNEL = "Urgent";

        public static readonly string REGEX_STR = $"\\[({BACKED_CHANNEL}||{FRONTENT_CHANNEL}||{QA_CHANNEL}||{URGENT_CHANNEL})\\]";
    }
}
