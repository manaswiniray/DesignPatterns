using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IUser : IUserState
    {
     /*   void SendMessage(string message);
        void ReceiveMessage(string message);
        void GetStatus(string status); */
        void ChangeState(IUserState userState);
    }
}
