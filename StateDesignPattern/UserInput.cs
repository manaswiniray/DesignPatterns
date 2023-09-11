using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class UserInput : IUserInput
    {
        public int InputChoice()
        {
            Console.WriteLine("Which State you want to show?");
            Console.WriteLine(" 1. Online\n 2. Offline \n 3. Busy\n 4. Away");
            int userChoice=int.Parse(Console.ReadLine());

            return userChoice;
        }
    }
}
