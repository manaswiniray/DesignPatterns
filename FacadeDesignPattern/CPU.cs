using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class CPU : ICPU
    {
        public void Start()
        {
            Console.WriteLine("CPU Starting");
        }

        public void Stop()
        {
            Console.WriteLine("CPU Stopping");
        }
    }
}
