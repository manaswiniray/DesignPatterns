using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public abstract class AbstractEmployee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AbstractEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract float CalculateBonus(float salary);

        public abstract float GetMinimumSalary();

        public override string ToString()
        {
            return Id.ToString()+" "+Name.ToString();
        }
    }
}
