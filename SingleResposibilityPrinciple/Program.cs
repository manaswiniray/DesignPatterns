namespace SingleResposibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Register("KIL48342", "8492rjfena", "hello@123");
            employee.LogIn("KIL48342", "8492rjfena");

            HR hR = new HR();
            hR.SendEMail("Welcome to the Organisation");

            Logger logger = new Logger();
            logger.LogError("You don't have the access");
        }
    }
}