using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuizMaker.Register
{
    class Register
    {
        private string username { get; set; }
        private string passw { get; set; }
        private string email { get; set; }
        private string first_name { get; set; }
        private string last_name { get; set; }

        public Register(string user, string pass, string email, string fn, string ln)
        {
            this.username = user;
            this.passw = pass;
            this.email = email;
            this.first_name = fn;
            this.last_name = ln;
        }

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
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";

            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsRegistered(string user, string pass, string email, string fn, string ln)
        {
            if (String.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please enter a username!");
                return false;
            }
            else if (SpecialCharactersValidator(user) == true)
            {
                MessageBox.Show("No special characters are allowed");
                return false;
            }
            else
            {
                if (String.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please enter a password!");
                    return false;
                }
                //validate if there are any special characters in the password
                else if (SpecialCharactersValidator(pass) == true)
                {
                    MessageBox.Show("No special characters are allowed");
                    return false;
                }
                else
                {
                    if (String.IsNullOrEmpty(email))
                    {
                        MessageBox.Show("Please enter your email adress!");
                        return false;
                    }
                    //validate if there are any special characters in the password
                    else if (SpecialCharactersValidator(email) == true)
                    {
                        MessageBox.Show("No special characters are allowed");
                        return false;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(fn))
                        {
                            MessageBox.Show("Please enter your First Name!");
                            return false;
                        }
                        //validate if there are any special characters in the password
                        else if (SpecialCharactersValidator(fn) == true)
                        {
                            MessageBox.Show("No special characters are allowed");
                            return false;
                        }
                        else if (StringValidator(fn) == true)
                        {
                            MessageBox.Show("Numbers are not allowed");
                            return false;
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(ln))
                            {
                                MessageBox.Show("Please enter your Last Name!");
                                return false;
                            }
                            //validate if there are any special characters in the password
                            else if (SpecialCharactersValidator(ln) == true)
                            {
                                MessageBox.Show("No special characters are allowed");
                                return false;
                            }
                            else if (StringValidator(ln) == true)
                            {
                                MessageBox.Show("Numbers are not allowed");
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

        public void RegisterUser(string user, string pass, string email, string fn, string ln)
        {

            if (IsRegistered(user, pass, email, fn, ln))
            {
                MultipleChoiceDataSetTableAdapters.UserTableAdapter userTableAdapter = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
                userTableAdapter.RegisterQuery(user, pass, email, fn, ln);
                int u = userTableAdapter.Update(new MultipleChoiceDataSet.UserDataTable());

                MailHandler.SendMailController.SendVerificationMail(email);

                
            }

        }
    }
}
