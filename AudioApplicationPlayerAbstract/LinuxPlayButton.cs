﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioApplicationPlayerAbstract
{
    internal class LinuxPlayButton : IPlayButton
    {
        public void Play()
        {
            Console.WriteLine("In Linux, Play Button is clicked");
        }
    }
}
