using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Employee : IEmployee
    {
        private string _name;
        private double _salary;

        public Employee(string name, double salary) 
        {
            _name = name;
            _salary = salary;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetSalary()
        {
            return _salary;
        }
    }
}
