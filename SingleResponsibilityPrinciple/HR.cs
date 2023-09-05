using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    public class HR : IEMail
    {
        public void SendEMail(string emailContent)
        {
            Console.WriteLine(emailContent);
        }
    }
}
