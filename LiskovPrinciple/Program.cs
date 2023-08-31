namespace LiskovPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractEmployee> list1 = new List<AbstractEmployee>();
            list1.Add(new PermanentEmployee(1,"Ram"));
            list1.Add(new TemporaryEmployee(2, "Sita"));
            //    list1.Add(new Intern(3, "Shyam")); Not Possible because Intern does not extends AbstractEmployee

            List<IEmployee> list2 = new List<IEmployee>();
            list2.Add(new PermanentEmployee(1, "Ram"));
            list2.Add(new TemporaryEmployee(2, "Sita"));
            list2.Add(new Intern(3, "Shyam"));

        }
    }
}