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
    public partial class UserDataControl : UserControl
    {
        public UserDataControl()
        {
            InitializeComponent();
        }

        //settings button gia energopoihsh - apenergopoihsh sta components
        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            if (UserIDBox.ReadOnly)
            {
                UserIDBox.ReadOnly = true;
                RoleBox.ReadOnly = false;
                NameBox.ReadOnly = false;
                LastNameBox.ReadOnly = false;
                EmailBox.ReadOnly = false;
                
                
                DeleteButton.Enabled = true;
                UpdateButton.Enabled = true;
                UserReset.Enabled = true;
            }
            else
            {
                UserIDBox.ReadOnly = true;
                RoleBox.ReadOnly = true;
                NameBox.ReadOnly = true;
                LastNameBox.ReadOnly = true;
                EmailBox.ReadOnly = true;
                
                
                DeleteButton.Enabled = false;
                UpdateButton.Enabled = false;
                UserReset.Enabled = false;
            }
        }

        private void UserReset_Click(object sender, EventArgs e)
        {
            UserIDBox.Text = "";
            RoleBox.Text = "";
            NameBox.Text = "";
            LastNameBox.Text = "";
            EmailBox.Text = "";
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadUserFields();
        }
        private void LoadUserFields()
        {
            if (!String.IsNullOrWhiteSpace(SearchIDBox.Text))
            {
                LoginHandler.User user = DBConnection.SearchAccountData(SearchIDBox.Text);
                if (user.name != null)
                {
                    UserIDBox.Text = "" + user.userID;
                    RoleBox.Text = user.role;
                    NameBox.Text = user.name;
                    LastNameBox.Text = user.surname;
                    EmailBox.Text = user.email;
                    user = DBConnection.SearchBlockData(user);
                    if (user.reason != null)
                    {
                        BlockData.blockID = user.blockID;
                        BlockData.reason = user.reason;
                        BlockData.days = user.blockedDays;
                        BlockData.blocked = user.isBlocked;
                        if (BlockData.blocked)
                        {
                            BlockButton.Text = "Unblock";
                        }
                    }
                    else
                    {
                        BlockData.blockID = 0;
                        BlockData.reason = "";
                        BlockData.days = 0;
                        BlockButton.Text = "Block";
                    }
                }


            }
        }

        private void SearchIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                LoadUserFields();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UserTextIsFilled())
            {
                DialogResult res = MessageBox.Show("Confirm update user data", "Confirm", MessageBoxButtons.OKCancel);
                if(res == DialogResult.OK)
                {
                    bool updated = DBConnection.UpdateUserData(new LoginHandler.User()
                    {
                        userID = Convert.ToInt32(UserIDBox.Text),
                        role = RoleBox.Text,
                        name = NameBox.Text,
                        surname = LastNameBox.Text,
                        email = EmailBox.Text
                    });
                    if (updated)
                    {
                        MessageBox.Show("User Updated succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Try again with another values");
                    }
                }
            }
        }
        private bool UserTextIsFilled()
        {
            return !String.IsNullOrWhiteSpace(UserIDBox.Text) &&
                !String.IsNullOrWhiteSpace(RoleBox.Text) &&
                !String.IsNullOrWhiteSpace(NameBox.Text) &&
                !String.IsNullOrWhiteSpace(LastNameBox.Text) &&
                !String.IsNullOrWhiteSpace(EmailBox.Text);
        }

        

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(@"Do you really want to delete user '"+UserIDBox.Text+"'?", "Confirm", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                bool deleted = DBConnection.DeleteUser(Convert.ToInt32(UserIDBox.Text));
                if (deleted) MessageBox.Show("User deleted");
                else MessageBox.Show("Something went wrong. User not deleted");
            }
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserIDBox.Text))
            {
                MessageBox.Show("You did not select any user");
            }
            else if (BlockData.blocked)
            {
                DBConnection.UpdateBlock(BlockData.blockID, BlockData.days, BlockData.reason, false);
            }
            else
            {
                DialogResult res = new BlockUserForm().ShowDialog();
                if(res == DialogResult.OK)
                {
                    if(BlockData.reason != null)
                    {
                        DBConnection.UpdateBlock(BlockData.blockID, BlockData.days, BlockData.reason, true);
                    }
                    else
                    {
                        DBConnection.InsertBlock(Convert.ToInt32(UserIDBox.Text), BlockData.reason, BlockData.days, true);
                    }
                }
            }
        }
    }
}
