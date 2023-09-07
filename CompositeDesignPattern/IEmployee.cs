using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public interface IEmployee
    {
        string Name { get; }
        double Salary { get; }
        void Display(string departmentName);
    }
}
