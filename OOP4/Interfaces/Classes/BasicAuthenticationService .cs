using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Interfaces.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string UserName,string PW)
        {
            if (UserName == "Alex" && PW == "123")
            {
                return true;
            }
            return false;
        }

        public bool AuthenticateUser()
        {
            throw new NotImplementedException();
        }




        public bool AuthorizeUser(string UserName, string Role)
        {
           if(UserName == "Alex" && Role == "Alex")
            {
                return true;
            }
           return false;
                
        }

        public bool AuthorizeUser()
        {
            throw new NotImplementedException();
        }
    }
}
