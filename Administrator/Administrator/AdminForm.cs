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



            button.BackColor = Color.FromArgb(3, 56, 73);
        }







        //login button events
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



        //close app
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
