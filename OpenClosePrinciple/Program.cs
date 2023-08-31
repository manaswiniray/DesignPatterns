namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fullTimeEmployee = new FullTimeEmployee();
            Console.WriteLine("Bonus: "+fullTimeEmployee.CalculateBonus(180000));

            Employee intern = new Intern();
            Console.WriteLine("Bonus: "+intern.CalculateBonus(50000));
            
        }
    }
}

