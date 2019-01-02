using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.LoginHandler
{
    static class Profile
    {
        private static int user_id;
        private static string username;
        private static string password;
        private static string name;
        private static string lastname;
        private static string email;
        private static string role;

        /*
        public Profile()
        {
            role = "Admin";
        }*/

        public static void SetUserID(int userID)
        {
            user_id = userID;
        }
        public static int GetUserID()
        {
            return user_id;
        }

        public static void SetUsername(string usrname)
        {
            username = usrname;
        }
        public static string GetUsername()
        {
            return username;
        }

        public static void SetPassword(string pssword)
        {
            password = pssword;
        }
        public static string GetPassword()
        {
            return password;
        }

        public static string GetRole()
        {
            return role;
        }

        public static void SetEmail(string mail)
        {
            email = mail;
        }
        public static string GetEmail()
        {
            return email;
        }

        public static void SetName(string nme)
        {
            name = nme;
        }
        public static string GetName()
        {
            return name;
        }

        public static void SetLastname(string lstname)
        {
            lastname = lstname;
        }
        public static string GetLastname()
        {
            return lastname;
        }

        public static string PrintUserData()
        {
            return user_id+" "+name+" "+lastname+ " " + email +" "+ username + " " + password;
        }
    }
}
