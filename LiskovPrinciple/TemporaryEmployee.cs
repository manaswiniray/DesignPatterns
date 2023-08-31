using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    internal class TemporaryEmployee : AbstractEmployee
    {
        public TemporaryEmployee(int id, string name) : base(id, name) { }
        public override float CalculateBonus(float salary)
        {
            return salary*0.1f;
        }

        public override float GetMinimumSalary()
        {
            return 25000;
        }
    }
}
