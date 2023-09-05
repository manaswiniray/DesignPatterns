namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringToIntConverter converter = new StringToIntConverter();

            IConverter adapter = new StringToIntAdapter(converter);

            Console.WriteLine("Enter your value for Conversion: ");
            string userInput=Console.ReadLine();

            int convertedResult=adapter.Converter(userInput);
            if (convertedResult == -1 )
            {
                Console.WriteLine("No Integer Value Exists for this Inputted String");
                return;
            }
            Console.WriteLine("The result is: {0}", convertedResult);
        }
    }
}