using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class AbstractMessage
    {
        public IMessenger messenger;
        public abstract void SendMessage(string message);
    }
}
