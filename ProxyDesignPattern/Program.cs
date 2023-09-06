namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentServer paymentServer = new PaymentServer();
            paymentServer.PaymentUI();
        }
    }
}