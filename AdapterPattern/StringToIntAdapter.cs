using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class StringToIntAdapter : IConverter        //Adapter
    {
        StringToIntConverter converter;

        public StringToIntAdapter(StringToIntConverter converter)
        {
            this.converter = converter;
        }
        public int Converter(string text)
        {
            return converter.ConvertStringToInt(text);
        }
    }
}
