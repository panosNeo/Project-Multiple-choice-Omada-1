using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    class Profile
    {
        private int user_id { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private string name { get; set; }
        private string lastname { get; set; }
        private string email { get; set; }
        private string role { get; set; }

        public Profile(int user_id, string username, string password, string role, string email, string lastname, string name)
        {
            this.user_id = user_id;
            this.username = username;
            this.password = password;
            this.role = role;
            this.email = email;
            this.name = name;
            this.lastname = lastname;
        }

        public string PrintUserData()
        {
            return user_id+" "+username+" "+name+" "+lastname+" "+email+" "+role;
        }
    }
}
