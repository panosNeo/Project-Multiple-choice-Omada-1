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

        //prosorina stoixeia gia testing
        Login.Login login = new Login.Login();
        
        
        //log in button
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passwordText.Text;
            bool a =login.LoginUser(user, pass);
            if (a)
            {
                ProfileControl pr = new ProfileControl();
                pr.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(pr);

                MainForm m = (MainForm)this.FindForm();
                m.SetLoginButtonText();
            }
            else
            {
                usernameText.Clear();
                passwordText.Clear();
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            RegisterControl re = new RegisterControl();
            re.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(re);
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordControl f = new ForgotPasswordControl();
            f.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(f);
        }
    }
}
