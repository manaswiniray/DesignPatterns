using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class Lights : Device
    {
        private bool IsSwitchOn=false;
        public override void AdjustDevice(int value)
        {
            Console.WriteLine("Adjusted to the value {0}", value);
        }

        public override void TurnOffDevice()
        {
            IsSwitchOn = false;
        }

        public override void TurnOnDevice()
        {
            IsSwitchOn = true;
        }

        public bool isSwitchOn()
        {
            return IsSwitchOn;
        }
    }
}
