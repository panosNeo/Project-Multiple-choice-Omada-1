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
                UserIDBox.ReadOnly = false;
                RoleBox.ReadOnly = false;
                NameBox.ReadOnly = false;
                LastNameBox.ReadOnly = false;
                EmailBox.ReadOnly = false;
                BlockIDBox.ReadOnly = false;
                ReasonBox.ReadOnly = false;
                DaysBox.ReadOnly = false;

                BlockCheckbox.Enabled = true;
                AddButton.Enabled = true;
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
                BlockIDBox.ReadOnly = true;
                ReasonBox.ReadOnly = true;
                DaysBox.ReadOnly = true;

                BlockCheckbox.Enabled = false;
                AddButton.Enabled = false;
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
            BlockIDBox.Text = "";
            ReasonBox.Text = "";
            DaysBox.Text = "";

            BlockCheckbox.Checked = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //MultipleChoiceDataSetTableAdapters.UserTableAdapter userData = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
            //MultipleChoiceDataSetTableAdapters.BlockedTableAdapter blockData = new MultipleChoiceDataSetTableAdapters.BlockedTableAdapter();
            if (!String.IsNullOrWhiteSpace(SearchIDBox.Text))
            {
                LoginHandler.User user = DBConnection.SearchAccountData(SearchIDBox.Text);
                if (user.name != null)
                {
                    UserIDBox.Text = ""+user.userID;
                    RoleBox.Text = user.role;
                    NameBox.Text = user.name;
                    LastNameBox.Text = user.surname;
                    EmailBox.Text = user.email;

                    //foreach(MultipleChoiceDataSet.BlockedRow blo in blockData.GetData())
                    //{
                    //    if(s.User_id == blo.User_id)
                    //    {
                    //        BlockIDBox.Text = ""+blo.ID;
                    //        ReasonBox.Text = blo.Reason;
                    //        DaysBox.Text = ""+blo.Days;
                    //        BlockCheckbox.Checked = blo.Blocked;
                    //    }
                    //}
                }
                
            }
        }
    }
}
