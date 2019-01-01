using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    class Profile
    {
        private string username;
        private string password;
        private string name;
        private string lastname;
        private string email;
        private string role;

        public Profile(string username,string password,string name,string lastname, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.role = role;
        }

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public string getName()
        {
            return name;
        }

        public string getLastname()
        {
            return lastname;
        }

        public string getEmail()
        {
            return email;
        }

        public string getRole()
        {
            return role;
        }
    }
}
