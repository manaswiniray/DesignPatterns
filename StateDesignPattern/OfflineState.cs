using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class OfflineState : IUserState
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Meesage Cannot be Received only Delivered in Offline State");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent Meesage in Offline State : {0}", message);
        }

        public string GetStatus()
        {
            return "Current Status : Offline";
        }
    }
}
