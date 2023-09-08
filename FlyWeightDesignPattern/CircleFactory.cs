using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDesignPattern
{
    public class CircleFactory
    {
        private Dictionary<int, ICircle> _circleCache = new Dictionary<int, ICircle>();

        public ICircle GetCircle(int radius)
        {
            if (!_circleCache.ContainsKey(radius))
            {
                _circleCache[radius] = new Circle(radius);
            }

            return _circleCache[radius];
        }
    }
}
