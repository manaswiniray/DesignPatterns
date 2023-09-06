namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TranslationServer translationServer = new TranslationServer();
            translationServer.Translate();
        }
    }
}