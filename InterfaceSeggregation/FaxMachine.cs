using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeggregation
{
    public class FaxMachine : IPrintTasks, IFaxTasks
    {
        public void FaxContent(string faxContent)
        {
            Console.WriteLine(faxContent);
        }

        public void PrintContent(string printContent)
        {
            Console.WriteLine(printContent);
        }
    }
}
