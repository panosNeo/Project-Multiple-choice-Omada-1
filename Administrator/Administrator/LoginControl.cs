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
            //ean den exei dwsei kwdiko h username tote petaxe warning
            if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                warningLabel.Visible = true;
                warningLabel.Text = "Please enter your username and your password.";
                return;
            }

            //filtrarw username & pass apo special characters
            string username = InputFilter(UsernameBox.Text);
            string password = InputFilter(PasswordBox.Text);

            //dhmiourgia login handler object gia tis leitourgies tautopoihshs
            LoginHandler.LoginHandler loginHandler = new LoginHandler.LoginHandler(username,password,false);

            //kalese th methodo gia tautopoihsh stoixeiwn
            loginHandler.SearchAccount();

            //ean uparxei o logariasmos tote kane login
            if (loginHandler.getSuccessLogin())
            {

                AdminForm adminForm = (AdminForm)this.FindForm();
                adminForm.LoginDesign();

                warningLabel.Visible = false;
                ResetButton.Visible = false;
            }
            else
            {
                //ean edwse lathos kwdiko h onoma tote petaxe warning
                //kai reset password button
                warningLabel.Visible = true;
                warningLabel.Text = "Wrong username or password.";
                ResetButton.Visible = true;
            }
        }

        //filtro gia special characters
        private string InputFilter(string text) {
            //under construction
            return text;
        }
    }
}
