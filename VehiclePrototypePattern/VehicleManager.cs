using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclePrototypePattern
{
    public class VehicleManager
    {
        BMW bmw;
        Audi audi;

        public VehicleManager()
        {
            bmw = new BMW();
            bmw.Initialize();

            audi=new Audi();
            audi.Initialize();
        }

        public IVehicle CreateAudi()
        {
            return audi.Clone();
        }

        public IVehicle CreateBMW()
        {
            return bmw.Clone();
        }
    }
}
