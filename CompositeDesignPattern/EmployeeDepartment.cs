using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class EmployeeDepartment : IEmployee
    {
        public string Name {get; set;}
        public double Salary { get; set;}

        List<IEmployee> employeeList = new List<IEmployee>();

        public EmployeeDepartment(string name)
        {
            Name = name;
        }

        public void AddEmployee(IEmployee employee)
        {
            employeeList.Add(employee);
        }

        public void Display(string departmentName)
        {
            if(departmentName!=null || departmentName.Equals(Name, StringComparison.OrdinalIgnoreCase))
            {
                foreach(IEmployee employee in employeeList)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
    }
}
