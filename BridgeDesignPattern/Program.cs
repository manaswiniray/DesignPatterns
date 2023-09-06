namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractMessage message = new AndroidPhone(new WhatsappMessenger());
            message.SendMessage("Hello");
        }
    }
}