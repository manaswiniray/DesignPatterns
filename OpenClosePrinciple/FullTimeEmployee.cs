using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class FullTimeEmployee : Employee
    {
        public override float CalculateBonus(float salary)
        {
            return salary*0.2f;
        }
    }
}
