using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class MetroTrainStrategy : ITravelStrategy
    {
        public string TravelToCollege()
        {
            return "Travelling via Metro Train";
        }
    }
}
