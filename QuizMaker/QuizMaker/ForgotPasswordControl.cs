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
    public partial class ForgotPasswordControl : UserControl
    {
        public ForgotPasswordControl()
        {
            InitializeComponent();
        }

        private void verificationBtn_Click(object sender, EventArgs e)
        {
            MultipleChoiceDataSetTableAdapters.UserTableAdapter u = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
            int exists = (int)u.searchEmail(EmailBox.Text);
            if (exists > 0)
            {
                MailHandler.SendMailController.SendPasswordResetMail(EmailBox.Text);
                ResetPasswordControl r = new ResetPasswordControl(Convert.ToInt32(MailHandler.SendMailController.getPasswordCode()), EmailBox.Text);
                r.Dock = DockStyle.Fill;
                Controls.Clear();
                Controls.Add(r);
            }
            else MessageBox.Show("Email does not belong into any account");

        }
    }
}
