using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Lights : Device
    {
        
        public override void AdjustDevice(int value)
        {
            Console.WriteLine("Adjusted to the value {0}", value);
        }

        public override void TurnOffDevice()
        {
            Console.WriteLine("Turning Off");
        }

        public override void TurnOnDevice()
        {
            Console.WriteLine("Turning On");
        }
    }
}
