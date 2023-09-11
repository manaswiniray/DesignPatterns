using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    interface IExpenseApprovalChain
    {
        void ExpenseApproval(long expenseAmount);
    }
}
