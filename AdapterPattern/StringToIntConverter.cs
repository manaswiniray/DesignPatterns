using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class StringToIntConverter       //the system has this method for conversion
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
