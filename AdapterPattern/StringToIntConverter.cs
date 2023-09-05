using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class StringToIntConverter
    {
        public int ConvertStringToInt(string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return -1;
            }
        }
    }
}
