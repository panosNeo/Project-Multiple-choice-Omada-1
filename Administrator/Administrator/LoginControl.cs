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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "test" && PasswordBox.Text == "test123")
            {
                AdminForm adminForm = (AdminForm)this.FindForm();
                adminForm.LoginDesign();
            }
            else
            {
                warningLabel.Visible = true;
                ResetButton.Visible = true;
            }
        }
    }
}
