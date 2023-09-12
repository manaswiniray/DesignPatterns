using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Light : ILight
    {
        public void TurnOff()
        {
            Console.WriteLine("Lights On");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lihts Off");
        }
    }
}
