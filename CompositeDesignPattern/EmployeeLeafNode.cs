using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class EmployeeLeafNode : IEmployeeNode
    {
        private readonly string _employeeName;    
        
        public EmployeeLeafNode(string employeeName)
        {
            _employeeName = employeeName;
        }
        public IList<IEmployeeNode> GetEmployeesList()
        {
            return null;
        }

        public string GetName()
        {
            return _employeeName;
        }
    }
}
