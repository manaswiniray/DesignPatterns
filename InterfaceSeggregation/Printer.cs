using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeggregation
{
    public class Printer : IPrintTasks, IScanTasks, IPhotocopyTasks
    {
        public void PhotocopyContent(string photocopyContent)
        {
            Console.WriteLine(photocopyContent);
        }

        public void PrintContent(string printContent)
        {
            Console.WriteLine(printContent);
        }

        public void ScanContent(string scanContent)
        {
            Console.WriteLine(scanContent);
        }
    }
}
