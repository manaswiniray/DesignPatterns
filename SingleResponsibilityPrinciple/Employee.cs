using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    public class Employee : IUser
    {
        public void LogIn(string userId, string password)
        {
            Console.WriteLine("You are logged in with User Id: {0} and Password: {1}",userId,password);
        }

        public void Register(string userId, string password, string eMail)
        {
            Console.WriteLine("You are registered with User Id: {0}, Password: {1} and E Mail: {2}", userId, password,eMail);
        }

    }
}
