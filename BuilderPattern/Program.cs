namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICarBuilder bmwCarBuilder = new BMW();
            bmwCarBuilder.AddSteeringCover();
            bmwCarBuilder.AddSeatCover();
            bmwCarBuilder.AddMobileStand();
            bmwCarBuilder.AddHeadLight();

            ICar bmwCar= bmwCarBuilder.Build();
            bmwCar.Display();

            Console.WriteLine("----------------------------------------");

            ICarBuilder audiCarBuilder = new Audi();
            audiCarBuilder.AddSteeringCover();
            audiCarBuilder.AddMobileStand();
            

            ICar audiCar = audiCarBuilder.Build();
            audiCar.Display();
        }
    }
}
