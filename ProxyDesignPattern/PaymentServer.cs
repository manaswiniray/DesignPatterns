using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class PaymentServer
    {
        private readonly IUserInput _userInput = new UserInput();
        public void PaymentUI()
        {
            int userAccountNo = _userInput.UserInputAccountNo();
            int userPin = _userInput.UserInputPin();

            ISecurityBranch account1 = new PaymentGatewayProxy();

            if (account1.ValidatePin(userAccountNo, userPin))
            {
                Console.WriteLine("Enter Amount: ");
                int userAmount = int.Parse(Console.ReadLine());
                account1.WithdrawMoney(userAccountNo, userAmount);
            }
            else
            {
                Console.WriteLine("Incorrect Pin");
            }
        }
    }
}
