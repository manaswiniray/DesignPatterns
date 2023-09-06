using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class IOSPhone : AbstractMessage
    {
        public IOSPhone(IMessenger messenger)
        {
            this.messenger = messenger;
        }
        public override void SendMessage(string message)
        {
            messenger.SendMessage(message);
        }
    }
}
