using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IUserState
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
        string GetStatus();
    }
}
