namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISecurityBranch account1 = new ATM();

            Console.WriteLine("Enter Account No.: ");
            int userAccountNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Pin: ");
            int userPin = int.Parse(Console.ReadLine());

            if (account1.ValidatePin(userAccountNo,userPin))
            {
                Console.WriteLine("Enter Amount: ");
                int userAmount = int.Parse(Console.ReadLine());
                account1.WithdrawMoney(userAccountNo, userAmount);
            }
        }
    }
}