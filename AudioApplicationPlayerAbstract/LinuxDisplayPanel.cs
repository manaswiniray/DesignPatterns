﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    public class LinuxDisplayPanel : IDisplay
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
