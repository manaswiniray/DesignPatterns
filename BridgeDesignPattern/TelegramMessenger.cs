using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class TelegramMessenger : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("{0} sent using Telegram",message);
        }
    }
}
