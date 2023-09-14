using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public abstract class Device : IDevice
    {
        protected IMediator mediator;
       
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void TurnOffDevice();
        public abstract void TurnOnDevice();
        public abstract void AdjustDevice(int value);

    }
}
