using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class TakeAwayOrder : OrderProcessTemplate
    {
        protected override bool IsPaid()
        {
            return true;
        }

        protected override void PrepareOrder()
        {
            Console.WriteLine("Preparing TakeAway Order in 20 mins.");
        }

        protected override void ProcessPayment()
        {
            Console.WriteLine("Processing payment for TakeAway Order");
        }

        protected override void Service()
        {
            Console.WriteLine("Food will be served on the table for TakeAway Option");
        }

        protected override void TakeOrder()
        {
            Console.WriteLine("Taking order for the TakeAway Order");
        }
    }
}
