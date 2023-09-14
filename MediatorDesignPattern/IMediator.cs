using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public interface IMediator
    {
        void AddDevice(IDevice device);
        void TurnOffAllDevices();
        void TurnOnAllDevices();
        void TurnOffDevice(IDevice device);
        void TurnOnDevice(IDevice device);
        void AdjustDevice(IDevice device,int value);
    

    }
}
