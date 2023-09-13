using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class TravelContext : ITravelContext
    {
        private ITravelStrategy _travelStrategy;
        public void SetTravelStartegy(ITravelStrategy travelStrategy)
        {
            _travelStrategy=travelStrategy;
        }

        public string TravelToCollege()
        {
            return _travelStrategy.TravelToCollege();
        }
    }
}
