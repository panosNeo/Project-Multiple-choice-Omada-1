using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.Login;

namespace QuizMaker
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        Login.Login login = new Login.Login("admin", "1234");
       
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passwordText.Text;

            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in succesfully");
            }
            else
            {
                MessageBox.Show("Login Error!");
            }
        }
    }
}
