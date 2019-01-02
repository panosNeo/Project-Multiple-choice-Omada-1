﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class ProfileControl : UserControl
    {
        //object profile
        //private LoginHandler.Profile profile;

        public ProfileControl()
        {
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            //pairnw to profile object me to data tou user
            //profile = LoginHandler.LoginHandler.GetProfile();

            //kalese th methodo gia na elegxei 
            //kai na emfanisei ta notes an uparxoun
            CheckForNotes();


            //tha travaei apo th vash ta dedomena
            //tou user kai tha ta fortwnei sta textboxes
            FillProfileData();
        }



        private void profileSettingsButton_Click(object sender, EventArgs e)
        {
            //string me to data tou user gia tuxwn update
            string userData = UserIDBox.Text + " "
                            + NameBox.Text + " " 
                            + LastNameBox.Text + " " 
                            + EmailBox.Text + " " 
                            + UsernameBox.Text + " "
                            + PasswordBox.Text; 

            if (dataGroupbox.Enabled)
            {
                //an den einai idio to data tote kane save tis allages
                if (!userData.Equals(LoginHandler.Profile.PrintUserData()))
                {
                    LoginHandler.UserDataController.UpdateUserData(NameBox.Text,LastNameBox.Text,EmailBox.Text,UsernameBox.Text,PasswordBox.Text);
                    FillProfileData();
                }

                dataGroupbox.Enabled = false;
            }
            else
                dataGroupbox.Enabled = true;
        }

        //logout button
        private void profileLogoutButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = (AdminForm)this.FindForm();
            adminForm.LogoutDesign();
        }


        //show password in passwordBox
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                PasswordBox.PasswordChar = '\0';
            else
                PasswordBox.PasswordChar = '*';
        }

        //
        private void CheckForNotes()
        {
            //under construction
            //tha elegxei an uparxoun reports
            //tha elegxei an uparxoun feedbacks 
            //kai tha ftiaxnei labels sto Notes group box
        }

        //kanei fill ta textboxes me ta data tou admin
        public void FillProfileData()
        {
            UserIDBox.Text = LoginHandler.Profile.GetUserID().ToString();
            NameBox.Text = LoginHandler.Profile.GetName();
            LastNameBox.Text = LoginHandler.Profile.GetLastname();
            EmailBox.Text = LoginHandler.Profile.GetEmail();
            UsernameBox.Text = LoginHandler.Profile.GetUsername();
            PasswordBox.Text = LoginHandler.Profile.GetPassword();

            //dwse to name tou user sto label
            welcomeLabel.Text = "Welcome "+NameBox.Text;
        }
    }
}
