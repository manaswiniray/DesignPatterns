using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class EmployeeParentNode : IEmployeeNode
    {
        private readonly string _employeeName;  

        private readonly List<IEmployeeNode> _employeesList;

        public EmployeeParentNode(string employeeName)
        {
            _employeeName = employeeName;
            _employeesList = new List<IEmployeeNode>();
        }

        public IList<IEmployeeNode> GetEmployeesList()
        {
            return _employeesList;
        }

        public string GetName()
        {
            return _employeeName;
        }

       public void Add(IEmployeeNode employeeNode)
        {
            _employeesList.Add(employeeNode);
        }
    }
}
