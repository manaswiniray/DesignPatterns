using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CabStrategy : ITravelStrategy
    {
        public string TravelToCollege()
        {
            return "Travelling via Cab";
        }
    }
}
