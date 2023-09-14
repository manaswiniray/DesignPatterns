using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class SmartAssistantMediator : IMediator
    {
        private IList<IDevice> _deviceList = new List<IDevice>();
        
        public void AddDevice(IDevice device)
        {
            _deviceList.Add(device);
            device.SetMediator(this);
        }

        public void TurnOnAllDevices()
        {
            Console.WriteLine("Switching On All Devices");
            foreach (var device in _deviceList)
            {
                device.TurnOnDevice();
            }
        }

        public void TurnOffAllDevices()
        {
            Console.WriteLine("Switching Off All Devices");
            foreach (var device in _deviceList)
            {
                device.TurnOffDevice();
            }
        }

        public void TurnOnDevice(IDevice device)
        {
            Console.WriteLine($"{device} is turned On");
            device.TurnOnDevice();
        }

        public void TurnOffDevice(IDevice device)
        {
            Console.WriteLine("{0} is turned On", device);
            device.TurnOffDevice();
        }

        public void AdjustDevice(IDevice device, int value)
        {
            Console.WriteLine("{0} device is adjusted to {1} value.", device, value);
            device.AdjustDevice(value);
        }
    }
}
