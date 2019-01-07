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
            //username is valid...
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
                    // the password is valid...
                    else
                    {
                        return true;
                    }
                       
                }
                
            
        }

        public void LoginUser(string user, string pass)
        {
            if (IsLoggedIn(user, pass)) { 
                //Using the adapter to validate through queries the login info and also store the Id of the user that logged in
                MultipleChoiceDataSetTableAdapters.UserTableAdapter userTableAdapter = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();

                try
                {
                    int userID = (int)userTableAdapter.ReturnUserId(user, pass);
               
                    MessageBox.Show("You logged in succesfully");
                }catch(Exception)
                {
                    MessageBox.Show("Your username or password is incorrect");
                }



            }
        }

      
    }
}
