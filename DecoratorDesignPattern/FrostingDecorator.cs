using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class FrostingDecorator : CakeDecorator
    {
        public FrostingDecorator(ICake cake) : base(cake)
        {
        }

        public override string GetContents()
        {
            return base.GetContents() + "With Frosting Added";
        }

        public override double TotalCost()
        {
            return base.TotalCost() + 50;
        }
    }
}
