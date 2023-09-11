using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class DepartmentSupervisor : ChainHandler
    {
        public override void HandleExpense(long expenseAmount)
        {
            if (expenseAmount <= 5000)
            {
                Console.WriteLine("The expense is approved by the DepartmentSupervisor");
            }
            else
            {
                Console.WriteLine("We have to go to the Senior : Finance Supervisor");
                nextChainHandler.HandleExpense(expenseAmount);
            }
        }
    }
}
