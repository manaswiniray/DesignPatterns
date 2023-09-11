using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class StateController : IStateController
    {
        readonly UserInput userInput = new UserInput();
        
        public IUserState userStateController()
        {
            IUserState userState;
            int userChoice = userInput.InputChoice();

            switch (userChoice)
            {
                case 1:
                    userState = new OnlineState();
                    break;
                case 2:
                    userState = new OfflineState();
                    break;
                case 3:
                    userState = new BusyState();
                    break;
                case 4:
                    userState = new AwayState();
                    break;
                default:
                    Console.WriteLine("Not choosen");
                    userState = null;
                    break;
            }

            return userState;
        }
    }
}
