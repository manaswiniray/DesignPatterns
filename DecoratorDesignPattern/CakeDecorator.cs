using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CakeDecorator : ICake
    {
        protected ICake cake;

        public CakeDecorator(ICake cake)
        {
            this.cake = cake;
        }

        public virtual string GetContents()
        {
            return cake.GetContents();
        }

        public virtual double TotalCost()
        {
            return (double)cake.TotalCost();
        }
    }
}
