using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class PowerManagementFacade : IPowerManagementFacade
    {
        private ICPU _cPU;
        private IMemory _memory;
        private IPowerSupply _powerSupply;

        public PowerManagementFacade()
        {
            _cPU = new CPU();
            _memory = new Memory();
            _powerSupply = new PowerSupply();
        }

        public void StartComputer()
        {
            _cPU.Start();
            _memory.Load();
            _powerSupply.SwitchOn();
        }

        public void StopComputer()
        {
            _cPU.Stop();
            _memory.Unload();
            _powerSupply.SwitchOff();
        }

    }
}
