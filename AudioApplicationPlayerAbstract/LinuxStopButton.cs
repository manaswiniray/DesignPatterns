﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class LinuxStopButton : IStopButton
    {
        public void Stop()
        {
            Console.WriteLine("In Linux, Stop Buttton is clicked!!!");
        }
    }
}
