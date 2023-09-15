using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class ChannelIterator : IChannelIterator
    {
        private readonly IList<IChannel> _channelList;
        private int _index;
        public ChannelIterator(IList<IChannel> channelList)
        {
            _channelList = channelList;
        }
        public bool HasNext()
        {
            return _index < _channelList.Count;
        }

        public IChannel Next()
        {
            IChannel channel = _channelList[_index++];
            return channel;
        }
    }
}
