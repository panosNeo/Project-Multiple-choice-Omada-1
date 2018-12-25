using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //leitourgies gia to onLoad
        private void AdminForm_Load(object sender, EventArgs e)
        {
           
        }


        //move from TopPanel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }//move from TopPanel

        //buttons design
        private void setButtonDesign(Button button) {
            Account.BackColor = Color.FromArgb(0,29,39);
            Subject.BackColor = Color.FromArgb(0, 29, 39);
            User.BackColor = Color.FromArgb(0, 29, 39);
            Question.BackColor = Color.FromArgb(0, 29, 39);
            Report.BackColor = Color.FromArgb(0, 29, 39);
            Feedback.BackColor = Color.FromArgb(0, 29, 39);

            button.BackColor = Color.FromArgb(3, 56, 73);
        }




        //sta Mouse-enter -- Mouse-leave events
        //allazoun ta xrwmata twn grammatwn sta buttons
        //sta Click events allazei to background color gia ta buttons

        //Account button events
        private void Account_Click(object sender, EventArgs e)
        {
            setButtonDesign(Account);
        }
        private void Account_MouseEnter(object sender, EventArgs e)
        {
            Account.ForeColor = Color.White;
        }
        private void Account_MouseLeave(object sender, EventArgs e)
        {
            Account.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //subject button events
        private void Subject_Click(object sender, EventArgs e)
        {
            setButtonDesign(Subject);
        }
        private void Subject_MouseEnter(object sender, EventArgs e)
        {
            Subject.ForeColor = Color.White;
        }
        private void Subject_MouseLeave(object sender, EventArgs e)
        {
            Subject.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //User button events
        private void User_Click(object sender, EventArgs e)
        {
            setButtonDesign(User);
        }
        private void User_MouseEnter(object sender, EventArgs e)
        {
            User.ForeColor = Color.White;
        }
        private void User_MouseLeave(object sender, EventArgs e)
        {
            User.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //question button events
        private void Question_Click(object sender, EventArgs e)
        {
            setButtonDesign(Question);
        }
        private void Question_MouseEnter(object sender, EventArgs e)
        {
            Question.ForeColor = Color.White;
        }
        private void Question_MouseLeave(object sender, EventArgs e)
        {
            Question.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //report button events
        private void Report_Click(object sender, EventArgs e)
        {
            setButtonDesign(Report);
        }
        private void Report_MouseEnter(object sender, EventArgs e)
        {
            Report.ForeColor = Color.White;
        }
        private void Report_MouseLeave(object sender, EventArgs e)
        {
            Report.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //Feedback button events
        private void Feedback_Click(object sender, EventArgs e)
        {
            setButtonDesign(Feedback);
        }
        private void Feedback_MouseEnter(object sender, EventArgs e)
        {
            Feedback.ForeColor = Color.White;
        }
        private void Feedback_MouseLeave(object sender, EventArgs e)
        {
            Feedback.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //close button events
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = Color.Red;
        }
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.FromArgb(3,56,73);
        }

        
    }
}
