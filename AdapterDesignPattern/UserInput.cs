using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class UserInput : IUserInput
    {
        public string fetchInputForConversion()
        {
            Console.WriteLine("Give your text for Translation: ");
            string inputString = Console.ReadLine();
            return inputString;
        }

        public int fetchInputForChoice()
        {
            Console.WriteLine("In which language you need translation \n1.Hindi \n2.Bengali? ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
