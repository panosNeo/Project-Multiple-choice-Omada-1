using System;
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
        public ProfileControl()
        {
            InitializeComponent();
        }


        private void ProfileControl_Load(object sender, EventArgs e)
        {
            //kalese th methodo gia na elegxei 
            //kai na emfanisei ta notes an uparxoun
            CheckForNotes();


            //tha travaei apo th vash ta dedomena
            //tou user kai tha ta fortwnei sta textboxes
            FillProfileData();
        }



        private void profileSettingsButton_Click(object sender, EventArgs e)
        {
            if (dataGroupbox.Enabled  )
            {
                //
                //leipei to save changes
                //
                dataGroupbox.Enabled = false;
            }
            else
                dataGroupbox.Enabled = true;
        }

        private void profileLogoutButton_Click(object sender, EventArgs e)
        {
            //leipei to logout
        }


        //show password in passwordBox
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                PasswordBox.PasswordChar = '\0';
            else
                PasswordBox.PasswordChar = '*';
        }

        private void CheckForNotes()
        {
            //under construction
            //tha elegxei an uparxoun reports
            //tha elegxei an uparxoun feedbacks 
            //kai tha ftiaxnei labels sto Notes group box
        }

        private void FillProfileData()
        {
            //under construction
            NameBox.Text = "Test";
            LastNameBox.Text = "Testing";
            EmailBox.Text = "test@it.teithe.gr";
            UsernameBox.Text = "test123";
            PasswordBox.Text = "testing123";
        }
    }
}
