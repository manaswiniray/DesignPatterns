using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Bank : ISecurityBranch
    {
        static readonly int actualPin = 9099;
        public bool ValidatePin(int accountNumber, int pin)
        {
            return actualPin == pin;
        }

        public void WithdrawMoney(int accountNumber, int amount)
        {
            Console.WriteLine("{0} has withdrawn Rs.{1} ",accountNumber, amount);
        }
    }
}
