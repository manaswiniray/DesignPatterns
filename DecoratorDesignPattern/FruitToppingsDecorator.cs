using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class FruitToppingsDecorator : CakeDecorator
    {
        public FruitToppingsDecorator(ICake cake) : base(cake)
        {
        }

        public override string GetContents()
        {
            return base.GetContents() + "With Fruit Toppings Added";
        }

        public override double TotalCost()
        {
            return base.TotalCost() + 150;
        }
    }
}
