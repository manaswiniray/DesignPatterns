using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Intern : Employee
    {
        public override float CalculateBonus(float salary)
        {
            return 0;
        }
    }
}
