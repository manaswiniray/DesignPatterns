using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class Cake : ICake
    {
        public string GetContents()
        {
            return "Cake ";
        }

        public double TotalCost()
        {
            return 299;
        }
    }
}
