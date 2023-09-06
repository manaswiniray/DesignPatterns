using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class UserInput : IUserInput
    {
        public int UserInputAccountNo()
        {
            Console.WriteLine("Enter Account No.: ");
            int userAccountNo = int.Parse(Console.ReadLine());
            return userAccountNo;
        }

        public int UserInputPin()
        {
            Console.WriteLine("Enter Pin: ");
            int userPin = int.Parse(Console.ReadLine());
            return userPin;
        }
    }
}
