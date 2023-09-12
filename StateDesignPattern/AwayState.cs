using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class AwayState : IUserState
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Received Meesage: {0}", message);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent Meesage: {0}", message);
        }

        public string GetStatus()
        {
            return "Current Status : Away";
        }
    }
}
