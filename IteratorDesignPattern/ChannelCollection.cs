using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class ChannelCollection : IChannelCollection
    {
        private IList<IChannel> _channelList;

        public ChannelCollection()
        {
            _channelList = new List<IChannel>();
        }
        public void AddChannel(IChannel channel)
        {
            _channelList.Add(channel);
        }

        public IChannelIterator GetIterator()
        {
            return new ChannelIterator(_channelList);
        }

        public void RemoveChannel(IChannel channel)
        {
            _channelList.Remove(channel);
        }
    }
}
