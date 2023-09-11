using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class UserInput : IUserInput
    {
        public int InputExpense()
        {
            Console.WriteLine("Enter expense for approval: ");
            int n=int.Parse(Console.ReadLine());
            return n;
        }
    }
}
