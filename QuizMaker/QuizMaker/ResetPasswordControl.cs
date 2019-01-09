using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class ResetPasswordControl : UserControl
    {
        private int code;
        private string mail;
        private int countTry;
        public ResetPasswordControl(int secret, string email)
        {
            InitializeComponent();
            code = secret;
            mail = email;
            countTry = 0;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SubmitPassword();

        }
        private void SubmitPassword()
        {
            MultipleChoiceDataSetTableAdapters.UserTableAdapter u = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
            if (!String.IsNullOrWhiteSpace(firstNewPassText.Text) && !String.IsNullOrWhiteSpace(secondNewPassText.Text))
            {
                if (firstNewPassText.Text == secondNewPassText.Text)
                {
                    u.UpdatePassword(firstNewPassText.Text, mail);
                    Controls.Clear();
                    Controls.Add(new LoginControl() {
                        Dock = DockStyle.Fill
                    });
                }
                else
                {
                    MessageBox.Show("Passwords are not the same");
                }
            }
            else
            {
                MessageBox.Show("Please fill the password fields");
            }
        }
        private void verificationBtn_Click(object sender, EventArgs e)
        {
            if(countTry <= 3)
            {
                if (CodeBox.Text == code.ToString())
                {
                    resetPanel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Code is not he same. Try again");
                    countTry++;
                }
            }
            else
            {
                MessageBox.Show("You tried too many times! Is this your email?");
            }
        }

        private void firstNewPassText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                SubmitPassword();
            }
        }
    }
}
