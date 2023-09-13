using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class BusyState : IUserState
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Message only delivered in Busy State", message);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent Meesage in Busy State: {0}", message);
        }

        public string GetStatus()
        {
            return "Current Status : Busy";
        }
    }
}
