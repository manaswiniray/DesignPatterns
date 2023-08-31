using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    interface IEmployeeBonus
    {
        float CalculateBonus(float salary);
    }
}
