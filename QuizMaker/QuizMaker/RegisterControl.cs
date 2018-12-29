using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.Register;
using QuizMaker.MailHandler;
namespace QuizMaker
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private string user;
        private string pass;
        private string email;
        private string fn;
        private string ln;
        

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
           
            user = usernameText.Text;
            pass = passwordText.Text;
            email = emailText.Text;
            fn = firstNameText.Text;
            ln = lastNameText.Text;
<<<<<<< HEAD
            Register.Register re = new Register.Register(user, pass, email, fn, ln);
           

            if (re.IsRegistered(user, pass, email, fn, ln) == true)
            {
                MultipleChoiceDataSetTableAdapters.UserTableAdapter userTableAdapter = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
                userTableAdapter.RegisterQuery(user, pass, email, fn, ln);
                int u = userTableAdapter.Update(new MultipleChoiceDataSet.UserDataTable());
                /*
                
                
                SendMailController.SendVerificationMail(email);

                MailAuthenticationControl m = new MailAuthenticationControl();
                m.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(m);*/

=======
            Register.Register re = new Register.Register( user,  pass,  email,  fn,  ln);
>>>>>>> parent of 4726ff4... 1

            re.IsRegistered(user, pass, email, fn, ln);

            SendMailController.SendVerificationMail(email);

            MailAuthenticationControl m = new MailAuthenticationControl();
            m.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(m);
        }
    }
}
