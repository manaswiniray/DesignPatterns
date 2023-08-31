using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        float GetMinimumSalary();
    }
}
