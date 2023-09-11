using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Supervisor : ChainHandler
    {
        public override void HandleExpense(long expenseAmount)
        {
            if(expenseAmount <= 1000)
            {
                Console.WriteLine("The expense is approved by the Supervisor");
            }
            else
            {
                Console.WriteLine("We have to go the Senior : Department Supervisor.");
                nextChainHandler.HandleExpense(expenseAmount);
            }
        }
    }
}
