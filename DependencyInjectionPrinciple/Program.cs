namespace DependencyInjectionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            BusinessLogicLayer businessLogicLayer=new BusinessLogicLayer(dataAccessLayer );
            Console.WriteLine(businessLogicLayer);
        }
    }
}