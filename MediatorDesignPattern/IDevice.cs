using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public interface IDevice
    {
        void SetMediator(IMediator mediator);
        void TurnOffDevice();
        void TurnOnDevice();
        void AdjustDevice(int value);
    }
}
