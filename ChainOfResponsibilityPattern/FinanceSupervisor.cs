using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class FinanceSupervisor : ChainHandler
    {
        public override void HandleExpense(long expenseAmount)
        {
            if(expenseAmount <= 10000) 
            {
                Console.WriteLine("The expense is approved by the Finance Supervisor");
            }
            else
            {
                Console.WriteLine("It cannot be approved at once");
            }
        }
    }
}
