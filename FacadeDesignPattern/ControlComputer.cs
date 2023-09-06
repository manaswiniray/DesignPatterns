using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class ControlComputer
    {
        readonly IUserInput userInput=new UserInput();

        public void ControlPower()
        {
            int choice = userInput.GetChoice();

            PowerManagementFacade powerManagementFacade = new PowerManagementFacade();

            switch (choice)
            {
                case 1:
                    powerManagementFacade.StartComputer();
                    break;
                case 2:
                    powerManagementFacade.StopComputer();
                    break;
                case 3:
                    Console.WriteLine("No Choice Made");
                    break;
            }

        }
    }
}
