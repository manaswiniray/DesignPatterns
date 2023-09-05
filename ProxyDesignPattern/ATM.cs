using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ATM : ISecurityBranch                      //Proxy For Bank
    {
        private ISecurityBranch _branch;
        private Bank bank = new Bank();
        bool isAuthenticate;
        public bool ValidatePin(int accountNumber, int pin)
        {
            isAuthenticate=bank.ValidatePin(accountNumber, pin);
            if (!isAuthenticate)
            {
                return false;
            }
            return isAuthenticate;
        }

        public void WithdrawMoney(int accountNumber, int amount)
        {
            if(isAuthenticate && amount > 0)
            {
                bank.WithdrawMoney(accountNumber, amount);
            }
            else
            {
                Console.WriteLine("Transaction Failed");
            }
        }
    }
}
