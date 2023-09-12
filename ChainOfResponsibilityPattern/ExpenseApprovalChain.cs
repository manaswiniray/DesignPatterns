using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ExpenseApprovalChain : IExpenseApprovalChain
    {
        private Supervisor _supervisor = new Supervisor();
        private DepartmentSupervisor _departmentSupervisor = new DepartmentSupervisor();
        private FinanceSupervisor _financeSupervisor = new FinanceSupervisor();

        public ExpenseApprovalChain() 
        {
            _supervisor.SetNextChainHandler(_departmentSupervisor);
            _departmentSupervisor.SetNextChainHandler(_financeSupervisor);  
        }

        public void ApproveExpense(long expenseAmount)
        {
            if(expenseAmount > 0)
            {
                _supervisor.HandleExpense(expenseAmount);
            }
            else
            {
                Console.WriteLine("Enter the Amount Coorectly");
            }
        }
    }
}
