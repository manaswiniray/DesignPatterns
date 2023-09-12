using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class ChainHandler : IChainHandler
    {
        public ChainHandler nextChainHandler;

        public void SetNextChainHandler(ChainHandler nextChainHandler)
        {
            this.nextChainHandler = nextChainHandler;
        }

        public abstract void HandleExpense(long expenseAmount);
    }
}
