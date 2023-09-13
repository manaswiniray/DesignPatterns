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
            Console.WriteLine("Message Cannot Be Received In Away State");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Message Cannot Be Sent In Away State");
        }

        public string GetStatus()
        {
            return "Current Status : Away";
        }
    }
}
