using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class EmployeeDepartment : IEmployee
    {
        private string _name;
        private double _salary;

        private List<IEmployee> employeeList = new List<IEmployee>();

        public EmployeeDepartment(string name)
        {
            _name = name;
        }

        public void AddEmployee(IEmployee employee)
        {
            employeeList.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employeeList.Remove(employee);
        }

        public string GetName()
        {
            return _name;
        }

        public double GetSalary()
        {
            return (double)_salary;
        }

        public void GetEmployeeList()
        {
            foreach (IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.GetName()+" "+ employee.GetSalary());
            }
            Console.WriteLine(employeeList.Count);
        }

        public int EmployeeCount()
        {
            return employeeList.Count;
        }
    }
}
