using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    internal class Menu : IMenu
    {
        private ICommand command;

        public void SetCommand(ICommand command) { this.command = command; }

        public void Click()
        {
            command.StartExecution();
        }

       
    }
}
