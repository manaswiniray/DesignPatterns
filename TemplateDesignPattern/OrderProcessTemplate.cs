using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class OrderProcessTemplate
    {
        public void ProcessOrder()
        {
            TakeOrder();
            PrepareOrder();
            Service();
            if (IsPaid())
            {
                ProcessPayment();
            }
            else
            {
                Console.WriteLine("Payment already done!");
            }
        }

        protected abstract void TakeOrder();
        protected abstract void PrepareOrder();
        protected abstract void Service();
        protected abstract bool IsPaid();
        protected abstract void ProcessPayment();


    }

}
