using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp2
{
    public class SignIn
    {
        public string Authentication(string username, string password)
        {
            string msg = "";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Provide Username and password";
                return msg;
            }
            else
            {
                if (username == "Admin" && password == "Admin@123")
                {
                    msg = "Authentication Success";
                    return msg;
                }
                else
                {
                    msg = "Authentication Failed";
                    return msg;
                }
            }
           
        }
    }
}
