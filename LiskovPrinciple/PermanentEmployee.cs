using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    internal class PermanentEmployee : AbstractEmployee
    {
        public PermanentEmployee(int id, string name) : base(id, name) { }
        public override float CalculateBonus(float salary)
        {
            return salary * 0.2f;
        }

        public override float GetMinimumSalary()
        {
            return 180000;
        }
    }
}
