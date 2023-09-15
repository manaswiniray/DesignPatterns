﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public interface IChannelCollection
    {
        void AddChannel(IChannel channel);
        void RemoveChannel(IChannel channel);
        IChannelIterator GetIterator();
    }
}
