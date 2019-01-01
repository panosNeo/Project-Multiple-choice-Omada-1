using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    class LoginHandler
    {
        private string username;
        private string password;
        private bool stayLog;

        public LoginHandler(string username,string password,bool stayLog)
        {
            this.username = username;
            this.password = password;
            this.stayLog = stayLog;
        }

        public void SearchAccount()
        {

        }

        private void StayIn() {
            //checkarw gia na ton afhsw in
        }
    }
}
