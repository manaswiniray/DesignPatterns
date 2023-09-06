using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public interface IMemory
    {
        void Load();
        void Unload();
    }
}
