using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

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
            //kai na emfanisei ta notes
            CheckForNotes();

            //tha travaei apo th vash ta dedomena
            //tou user kai tha ta fortwnei sta textboxes
            FillProfileData();
        }
        
        private void profileSettingsButton_Click(object sender, EventArgs e)
        {
            SetProfileSettings();
        }

        private void SetProfileSettings()
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
                    //rwthse gia save
                    DialogResult dialogResult = MessageBox.Show("Do you want to save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //an save == yes tote kane save
                    if (dialogResult == DialogResult.Yes)
                    {
                        LoginHandler.UserDataController.UpdateUserData(NameBox.Text, LastNameBox.Text, EmailBox.Text, UsernameBox.Text, PasswordBox.Text);
                        FillProfileData();
                    }
                    else
                    {//an save == no tote kane fill to idio data 
                        FillProfileData();
                    }
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

        //tsekare an uparxei doyleia gia ton admin
        private void CheckForNotes()
        {
            NotesflowLayoutPanel.Controls.Clear();
            //des an yparxoun reports kai feedbacks
            LoginHandler.UserDataController.CheckForNotes();

            int feedbacks = LoginHandler.UserDataController.feedbacks;
            int reports = LoginHandler.UserDataController.reports;

            ProfileNote prof;
            prof = new ProfileNote();
            prof.SetData("Feedbacks to check out : ", feedbacks);
            prof.BackColor = Color.White;
            NotesflowLayoutPanel.Controls.Add(prof);

            prof = new ProfileNote();
            prof.SetData("Reports to check out : ", reports);
            prof.BackColor = Color.FromName("GradientActiveCaption");
            NotesflowLayoutPanel.Controls.Add(prof);
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

        private void SaveAdminData_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SetProfileSettings();
            }
        }
    }
}