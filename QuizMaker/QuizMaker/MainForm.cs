using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class MainForm : Form
    {
        //Η μεταβλητή menuVisible ελέγχεται για το αν το leftPanel είναι σε κατάσταση κλειστή ή ανοιχτή(false/true αντίστοιχα)
        private bool menuVisible;
        public MainForm()
        {
            InitializeComponent();
            menuVisible = true;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            //γίνεται clear του mainPanel για να μην μπουκώνει την μνήμη
            mainPanel.Controls.Clear();
            LoginControl l = new LoginControl();
            //δίνουμε dock fill για να αλλάζει το μέγεθος του user control ανάλογα με το μέγεθος του mainPanel
            l.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(l);
        }

        private void menuVisibleBtn_Click(object sender, EventArgs e)
        {
            // αλλάζουμε την τιμή menuVisible από true σε not true(false) ώστε να ξέρει την κατάσταση του leftMenu
            //η μέθοδος timer1_tick
            menuVisible = !menuVisible;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //παίρνουμε σε κάθε tick το size του leftPanel ώστε να αλλάξουμε τον άξονα Χ κατά 5 κάθε φορά
            Size leftPanelSize = leftPanel.Size;
            
            Point mainPanelLocation = mainPanel.Location;
            if (!menuVisible)
            {
                if (leftPanelSize.Width >= 32)
                {
                    leftPanelSize.Width = leftPanelSize.Width - 5;
                   
                    leftPanel.Size = leftPanelSize;
                    
                }
                else timer1.Stop();
            }
            else
            {
                if (leftPanelSize.Width <= 165)
                {
                    leftPanelSize.Width = leftPanelSize.Width + 5;
                    
                    leftPanel.Size = leftPanelSize;
                    
                }
                else timer1.Stop();
            }
        }

        private void LeftMenuButtons_Click(object sender, EventArgs e)
        {
            //στο tag των τριών button ορίζεται το panel που ανοίγουν
            string panelName = ((Button)sender).Tag.ToString();
            ChangePanel(panelName);
        }
        private void ChangePanel(string name)
        {
            mainPanel.Controls.Clear();
            switch (name)
            {
                case "createQuiz":
                    CreateQuizControl c = new CreateQuizControl();
                    c.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(c);
                    break;
                case "categories":
                    CategoriesControl d = new CategoriesControl();
                    d.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(d);
                    break;
                case "feelLucky":
                    FeelLuckyControl e = new FeelLuckyControl();
                    e.Dock = DockStyle.Fill;
                    mainPanel.Controls.Add(e);
                    break;
                default:
                    Console.WriteLine("No control selected");
                    break;
            }

        }
    }
}
