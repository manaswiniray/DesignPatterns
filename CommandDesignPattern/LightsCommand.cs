using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class LightsCommand : ICommand
    {
        private readonly ILight _light;

        public LightsCommand(ILight light)
        {
            _light = light;
        }

        public void StartExecution()
        {
            _light.TurnOn();
        }

        public void StopExecution()
        {
            _light.TurnOff();
        }
    }
}
