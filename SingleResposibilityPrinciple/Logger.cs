using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    public class Logger : ILogger
    {
        public void LogError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
