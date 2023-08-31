using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public class Intern : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Intern(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public float GetMinimumSalary()
        {
            return 50000;
        }

        public override string ToString()
        {
            return Id.ToString()+" "+Name.ToString();
        }
    }
}
