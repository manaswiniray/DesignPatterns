using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public interface ISecurityBranch
    {
        bool ValidatePin(int accountNumber, int pin);
        void WithdrawMoney(int accountNumber, int amount);
    }
}
