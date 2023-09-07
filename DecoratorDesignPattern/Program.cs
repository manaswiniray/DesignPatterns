namespace DecoratorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICake cake = new Cake();
            Console.WriteLine(cake.GetContents() + "\n" + cake.TotalCost());

            ICake birthdayCake = new ChocoChipsDecorator(new Cake());
            Console.WriteLine(birthdayCake.GetContents() + "\n" + birthdayCake.TotalCost());

            ICake anniversaryCake = new FruitToppingsDecorator(new FrostingDecorator(new Cake()));
            Console.WriteLine(anniversaryCake.GetContents() + "\n" + anniversaryCake.TotalCost());

            ICake cake1 = new CherryDecorator(new ChocoChipsDecorator(new Cake()));
            Console.WriteLine(cake1.GetContents() + "\n" + cake1.TotalCost());
        }
    }
}