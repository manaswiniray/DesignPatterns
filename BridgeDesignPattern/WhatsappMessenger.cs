using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class WhatsappMessenger : IMessenger
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("{0} sent using WhatsApp",message);
        }
    }
}
