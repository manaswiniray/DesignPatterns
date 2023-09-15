using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public interface IChannel
    {
        public double Frequncy { get; set; }
        public ChannelType Type { get; set; }
    }
}
