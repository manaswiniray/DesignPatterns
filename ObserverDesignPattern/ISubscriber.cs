﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface ISubscriber
    {
        void Update(string videoTitle,string channelName);
    }
}
