using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class UserInput : IUserInput
    {
        public int GetChoice()
        {
            Console.WriteLine("1. Start Computer \n2.Switch Off Computer");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
