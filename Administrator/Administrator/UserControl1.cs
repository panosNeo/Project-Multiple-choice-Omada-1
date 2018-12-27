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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
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
            }
        }
    }
}
