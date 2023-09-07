using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary) 
        {
            Name = name;
            Salary = salary;
        }
        public void Display(string departmentName)
        {
            Console.WriteLine("Employee Name: {0}, Salary: {1} ",Name,Salary);
        }
    }
}
