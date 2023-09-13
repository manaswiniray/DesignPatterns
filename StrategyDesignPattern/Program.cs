namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITravelContext busContext=new TravelContext();
            busContext.SetTravelStartegy(new BusStrategy());
            Console.WriteLine(busContext.TravelToCollege());
            
        }
    }
}