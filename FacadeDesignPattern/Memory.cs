using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Memory : IMemory
    {
        public void Load()
        {
            Thread.Sleep(800);
            Console.WriteLine("Memory Loading");
        }

        public void Unload()
        {
            Thread.Sleep(800);
            Console.WriteLine("Memory Unloading");
        }
    }
}
