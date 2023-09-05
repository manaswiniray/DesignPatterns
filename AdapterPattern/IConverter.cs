using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IConverter     //clients wants to use
    {
        int  Converter(string text);
    }
}
