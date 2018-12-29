using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.MailHandler;

namespace QuizMaker
{
    public partial class MailAuthenticationControl : UserControl
    {
        public MailAuthenticationControl()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (vCodeText.Text == SendMailController.getVerificationCode())
            {
                MessageBox.Show("Your email has been verified");
            }
        }
    }
}
