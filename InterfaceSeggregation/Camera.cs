using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeggregation
{
    public class Camera : IScanTasks
    {
        public void ScanContent(string scanContent)
        {
            Console.WriteLine(scanContent);
        }
    }
}
