using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    public class User
    {
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public int userID { get; set; }
        public int blockedDays { get; set; }
        public bool isBlocked { get; set; }
        public string reason { get; set; }


        public User(string un, string name, string surname, string email, int userID)
        {
            username = un;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.userID = userID;
        }

        public User() { }

    }
}
