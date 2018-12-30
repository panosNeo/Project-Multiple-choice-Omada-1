using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuizMaker.Login
{
    class Login
    {
        private string username { get; set; }
        private string passwd { get; set; }

        //initalize
        public Login(string user,string pass)
        {
            this.username = user;
            this.passwd = pass;
        }

        //Method that shows if an input has any special characters in it
        private bool SpecialCharactersValidator(string input)
        {
            string pattern = @"([<>\?\*\\\""/\|])+";

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method that clears the username and password textboxes
        private void ClearTexts(string user,string pass)
        {
            user = String.Empty;
            pass = String.Empty;

        }

        //Method that checks the requirments to be able to log in
        internal bool IsLoggedIn(string user,string pass)
        {
            //check if username is empty
            if (String.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please enter your username!");
                return false;
            }
            //validate if there are any special characters in the username
            else if (SpecialCharactersValidator(user)==true)
            {
                MessageBox.Show("No special characters are allowed");
                ClearTexts(user, pass);
                return false;
            }
            //check if the username is correct
            else
            {
                if (username != user)
                {
                    MessageBox.Show("Your username is incorrect");
                    ClearTexts(user, pass);
                    return false;
                }
                //username is correct...
                else
                {
                    //check if password is empty
                    if (String.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Please enter your password!");
                        return false;
                    }
                    //validate if there are any special characters in the password
                    else if (SpecialCharactersValidator(pass)==true)
                    {
                        MessageBox.Show("No special characters are allowed");
                        ClearTexts(user, pass);
                        return false;
                    }
                    //check if the password is correct
                    else if (passwd != pass)
                    {
                        MessageBox.Show("Your password is incorrect");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                       
                }
                
            }
        }

      
    }
}
