using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class ChocoChipsDecorator : CakeDecorator
    {
        public ChocoChipsDecorator(ICake cake) : base(cake)
        {
        }

        public override string GetContents()
        {
            return base.GetContents() + "With Choco Chips Added";
        }

        public override double TotalCost()
        {
            return base.TotalCost() + 40.5;
        }
    }
}
