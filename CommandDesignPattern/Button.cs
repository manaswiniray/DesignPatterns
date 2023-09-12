using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Button : IButton
    {
        private ICommand command;

        public void SetCommand(ICommand command) { this.command = command; }

        public void PressForExecution()
        {
            command.StartExecution();
        }

        public void PressToStopExecution()
        {
            command.StopExecution();    
        }
    }
}
