using NotiChannelDemo.Services;

namespace NotiChannelDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notiService = new NotificationService();

            notiService.InputChannel();
        }
    }
}