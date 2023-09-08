using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    public class Circle : ICircle
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public void DrawCircle(int x, int y)
        {
            Console.WriteLine("Circle at {0}, {1} of radius {2}", x, y, _radius);
        }
    }
}
