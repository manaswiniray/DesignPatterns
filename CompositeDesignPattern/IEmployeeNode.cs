using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public interface IEmployeeNode
    {
        string GetName();
        IList<IEmployeeNode> GetEmployeesList();
    }
}
