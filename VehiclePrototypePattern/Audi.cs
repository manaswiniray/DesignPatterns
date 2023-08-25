using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePrototypePattern
{
    public class Audi : IVehicle
    {
        public string Engine { get; set ; }
        public string VehicleNo { get; set; }

        public IVehicle Clone()
        {
            Console.WriteLine("Audi is Cloned");
            return new Audi();
        }

        public void Initialize()
        {
            Console.WriteLine("Audi is Initialized");
        }
    }
}
