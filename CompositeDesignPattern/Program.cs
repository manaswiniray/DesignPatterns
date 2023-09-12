namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee1 = new Employee("Ram",50000);
            IEmployee employee2 = new Employee("Shyam", 70000);
            IEmployee employee3 = new Employee("Sita", 90000);

            EmployeeDepartment employeeDepartment1 = new EmployeeDepartment("OCM");
            employeeDepartment1.AddEmployee(employee1);
            employeeDepartment1.AddEmployee(employee2);
            employeeDepartment1.AddEmployee(employee3);

            Console.WriteLine("OCM: ");
            employeeDepartment1.GetEmployeeList();


            EmployeeDepartment employeeDepartment2 = new EmployeeDepartment("DevOps");
            employeeDepartment2.AddEmployee(employee1);
            employeeDepartment2.AddEmployee(employee2);

            Console.WriteLine("\nDevOps: ");
            employeeDepartment2.GetEmployeeList();
        }
    }

   
}