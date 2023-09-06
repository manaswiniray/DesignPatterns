using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class PowerSupply : IPowerSupply
    {
        public void SwitchOff()
        {
            Thread.Sleep(1200);
            Console.WriteLine("Power Supply Cut");
        }

        public void SwitchOn()
        {
            Thread.Sleep(1200);
            Console.WriteLine("Power Supply Given");
        }
    }
}
