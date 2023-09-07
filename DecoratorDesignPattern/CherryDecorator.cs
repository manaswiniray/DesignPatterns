using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class CherryDecorator : ICake
    {
        private readonly ICake _cake;

        public CherryDecorator(ICake cake)
        {
            _cake = cake;
        }
        public string GetContents()
        {
            return _cake.GetContents() + "With Cherries Added";
        }

        public double TotalCost()
        {
            return _cake.TotalCost() + 35.5;
        }
    }
}
