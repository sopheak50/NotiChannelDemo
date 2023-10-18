using NotiChannelDemo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotiChannelDemo.Services
{
    internal class NotificationService
    {
        public void InputChannel()
        {
            Console.WriteLine("Please input the title: ");
            var str = Console.ReadLine();
            if(str != null)
            {
                Console.WriteLine(GetChannelFromString(str));
            }else
            {
                Console.WriteLine("You have not input anything");
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        private static string GetChannelFromString(string strChannel)
        {
            Regex regex = new Regex(@NotificationConstant.REGEX_STR);
            MatchCollection match = regex.Matches(strChannel);

            var foundChannel = new StringBuilder();
            foundChannel.Append("Receive channels: ");
            if (match.Count > 0) { 
                var list = match.ToList();
                int i = 0;
                list.ForEach(item =>
                {
                    var value = item.Value.Replace("[", "").Replace("]", "");
                    foundChannel.Append(i < list.Count - 1 ? $"{value}, " : $"{value}.");
                    i++;
                });
            }
            else
            {
                foundChannel.Append("not found.");
            }
            return foundChannel.ToString();
        }
    }
}
