namespace FlyWeightDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircleFactory circleFactory = new CircleFactory();

            ICircle circle = circleFactory.GetCircle(23);
            circle.DrawCircle(5,5);

            ICircle circle1 =new Circle(78);
            circle1.DrawCircle(2,5);
        }
    }
}