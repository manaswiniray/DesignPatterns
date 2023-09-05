using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    interface IUser
    {
        void LogIn(string userId, string password);
        void Register(string userId, string password,string EMail);
    }
}
