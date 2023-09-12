﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public interface IButton
    {
        void PressForExecution();
        void PressToStopExecution();
    }
}
