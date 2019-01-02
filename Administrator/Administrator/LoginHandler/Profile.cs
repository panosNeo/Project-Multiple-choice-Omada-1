using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    class Profile
    {
        private int user_id;
        private string username;
        private string password;
        private string name;
        private string lastname;
        private string email;
        private string role;

        public Profile()
        {
            role = "Admin";
        }

        public void SetUserID(int userID)
        {
            this.user_id = userID;
        }
        public int GetUserID()
        {
            return user_id;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetUsername()
        {
            return username;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetPassword()
        {
            return password;
        }

        public string GetRole()
        {
            return role;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string GetLastname()
        {
            return lastname;
        }

        public string PrintUserData()
        {
            return user_id+" "+name+" "+lastname+ " " + email +" "+ username + " " + password;
        }
    }
}
