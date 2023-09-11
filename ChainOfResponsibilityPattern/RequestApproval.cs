using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class RequestApproval : IRequestApproval
    {
        readonly UserInput userInput = new UserInput();
        public void UserRequestApproval()
        {
            int n = userInput.InputExpense();
            ExpenseApprovalChain expenseApprovalChain = new ExpenseApprovalChain();
            expenseApprovalChain.ExpenseApproval(n);
        }
    }
}
