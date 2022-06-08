using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class UserClass
    {
        private string UserName;
        private string Password;

        public UserClass()
        {

        }
        public UserClass(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public void setUserName(string userName)
        {
            this.UserName = userName;
        }

        public string getUserName()
        {
            return this.UserName;
        }
        public void setPasswor(string Passwr)
        {
            this.Password = Passwr;
        }

        public string getPassword()
        {
            return this.Password;
        }

    }
}
