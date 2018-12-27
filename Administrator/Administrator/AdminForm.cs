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
        private ProfileControl profileControl = new ProfileControl();   //profileControl object
        private SubjectControl subjectControl = new SubjectControl();   //subjectControl object
        private QuestionControl questionControl = new QuestionControl();//questionControl object
        private UserControl1 userControl1 = new UserControl1();         //userControl object


        public AdminForm()
        {
            InitializeComponent();
        }

        //leitourgies gia to onLoad
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //me to load allaxe to profile button xrwma kai kane switch UserControl
            setDesign(Profile,profileControl);
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

        //Design se buttons kai switch se user controls
        private void setDesign(Button button,UserControl userControl) {
            MainPanel.Controls.Clear();                         //kane clear ola ta controls tou mainpanel
            userControl.Dock = DockStyle.Fill;                  //kane fill to profileControl
            MainPanel.Controls.Add(userControl);                //pare sto mainPanel to profileControl

            Profile.BackColor = Color.FromArgb(0,29,39);
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
        private void Profile_Click(object sender, EventArgs e)
        {
            //kalese methodo gia xrwma kai switch Control
            setDesign(Profile,profileControl);
        }
        private void Profile_MouseEnter(object sender, EventArgs e)
        {
            Profile.ForeColor = Color.White;
        }
        private void Profile_MouseLeave(object sender, EventArgs e)
        {
            Profile.ForeColor = Color.FromName("GradientActiveCaption");
        }

        //subject button events
        private void Subject_Click(object sender, EventArgs e)
        {
            //kalese methodo gia xrwma kai switch Control
            setDesign(Subject,subjectControl);
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
            //kalese methodo gia xrwma kai switch Control
            setDesign(User,userControl1);
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
            //kalese methodo gia xrwma kai switch Control
            setDesign(Question,questionControl);
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
            //kalese methodo gia xrwma kai switch Control
            setDesign(Report,profileControl);
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
            //kalese methodo gia xrwma kai switch Control
            setDesign(Feedback,profileControl);
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
