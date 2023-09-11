using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class User : IUser
    {
        public IUserState currentState;

        public User() 
        {
            currentState = new OfflineState();
        }

        public void ChangeState(IUserState userState)
        {
            currentState = userState;
        }

        public void ReceiveMessage(string message)
        {
            currentState.ReceiveMessage(message);
        }

        public void SendMessage(string message)
        {
            currentState.SendMessage(message);
        }

        public string GetStatus()
        {
            return currentState.GetStatus();
        }
    }
}
