using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class Channel : IChannel
    {
        public double Frequncy { get; set; }
        public ChannelType Type { get; set; }

        public Channel(double frequncy, ChannelType type)
        {
            Frequncy = frequncy;
            Type = type;
        }
    }
}
