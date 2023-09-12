namespace TemplateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dine In Order: ");
            OrderProcessTemplate dineInOrder = new DineInOrder();
            dineInOrder.ProcessOrder();

            Console.WriteLine("\nTake Away Oder:");
            OrderProcessTemplate takeAwayOrder = new TakeAwayOrder();
            takeAwayOrder.ProcessOrder();
        }
    }
}