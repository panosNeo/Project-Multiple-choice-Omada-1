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
        Login.Login login = new Login.Login("admin", "1234");
       
        
        //log in button
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passwordText.Text;
            login.LoginUser(user, pass);
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            RegisterControl re = new RegisterControl();
            re.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(re);
        }
    }
}
