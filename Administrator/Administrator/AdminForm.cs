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
        //control objects
        private ProfileControl profileControl = new ProfileControl();
        private LoginControl loginControl = new LoginControl();  

        public AdminForm()
        {
            InitializeComponent();
        }

        //leitourgies gia to onLoad
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //me to load allaxe to profile button xrwma kai kane switch UserControl
            setDesign(Profile,loginControl);
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

        //an ginei to login me epituxia tote kaleitai h methodos 
        //kai diamorfwnei to design 
        public void LoginDesign() {
            setDesign(Profile,profileControl);
            MenuPanel.Visible = true;
        }

        //me to logout kaleitai h methodos gia allagh design
        public void LogoutDesign() {
            setDesign(Profile,loginControl);
            MenuPanel.Visible = false;
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
        //subject button events
        private void Subject_Click(object sender, EventArgs e)
        {
            SubjectControl subjectControl = new SubjectControl();
            //kalese methodo gia xrwma kai switch Control
            setDesign(Subject,subjectControl);
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if(((Button)sender).Tag != null && ((Button)sender).Tag.ToString() == "close")
            {
                ((Button)sender).BackColor = Color.Red;
            }
            else
            {
                ((Button)sender).ForeColor = Color.White;
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromName("GradientActiveCaption");
            if (((Button)sender).Tag != null && ((Button)sender).Tag.ToString() == "close")
            {
                ((Button)sender).BackColor = Color.FromArgb(3, 56, 73);
            }
            else
            {
                ((Button)sender).ForeColor = Color.FromName("GradientActiveCaption");
            }
        }

        //User button events
        private void User_Click(object sender, EventArgs e)
        {
            UserDataControl userControl1 = new UserDataControl();
            //kalese methodo gia xrwma kai switch Control
            setDesign(User,userControl1);
        }
        //question button events
        private void Question_Click(object sender, EventArgs e)
        {
            QuestionControl questionControl = new QuestionControl();
            //kalese methodo gia xrwma kai switch Control
            setDesign(Question,questionControl);
        }
        //report button events
        private void Report_Click(object sender, EventArgs e)
        {
            ReportControl reportControl = new ReportControl();
            //kalese methodo gia xrwma kai switch Control
            setDesign(Report,reportControl);
        }
        //Feedback button events
        private void Feedback_Click(object sender, EventArgs e)
        {
            FeedbackControl feedbackControl = new FeedbackControl();
            //kalese methodo gia xrwma kai switch Control
            setDesign(Feedback,feedbackControl);
        }
        //close button events
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}