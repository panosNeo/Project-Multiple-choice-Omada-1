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
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            setProfile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personal = "personal";
            if(((Button)sender).Tag.ToString() == "+")
            {
                personalDown = true;
                ((Button)sender).Tag = "-";
                
            }
            else
            {
                personalDown = false;
                ((Button)sender).Tag = "+";
            }
            ((Button)sender).Text = ((Button)sender).Tag.ToString() + " Personal Data";
            personalAnimationTimer.Start();
        }
        private string personal;
        private bool personalDown;
        private void panelTimer_Tick(object sender, EventArgs e)
        {
            if (personalDown)
            {
                if (personalPanel.Size.Height < 250)
                {
                    SetAnimation(personal, personalDown);
                }
                else personalAnimationTimer.Stop();
            }
            else
            {
                if (personalPanel.Size.Height > 50)
                {
                    SetAnimation(personal, personalDown);
                }
                else personalAnimationTimer.Stop();
            }
        }

        private void SetAnimation(string panel, bool down)
        {
            if(panel == "personal")
            {
                if (down)
                {
                    personalPanel.Size = new Size(personalPanel.Size.Width, personalPanel.Size.Height + 10);
                    quizPanel.Location = new Point(quizPanel.Location.X, quizPanel.Location.Y + 10);
                }
                else
                {
                    personalPanel.Size = new Size(personalPanel.Size.Width, personalPanel.Size.Height - 10);
                    quizPanel.Location = new Point(quizPanel.Location.X, quizPanel.Location.Y - 10);
                }
            }else if(panel == "quiz")
            {
                if (down)
                {
                    quizPanel.Size = new Size(quizPanel.Size.Width, quizPanel.Size.Height + 10);
                }
                else
                {
                    quizPanel.Size = new Size(quizPanel.Size.Width, quizPanel.Size.Height - 10);
                }
            }
        }
        private string quiz;
        private bool quizDown;
        private void button1_Click(object sender, EventArgs e)
        {
            quiz = "quiz";
            if (((Button)sender).Tag.ToString() == "+")
            {
                quizDown = true;
                ((Button)sender).Tag = "-";
            }
            else
            {
                quizDown = false;
                ((Button)sender).Tag = "+";
            }
            ((Button)sender).Text = ((Button)sender).Tag.ToString() + " My quizes";
            quizAnimtionTimer.Start();
        }

        private void quizAnimtionTimer_Tick(object sender, EventArgs e)
        {
            if (quizDown)
            {
                if (quizPanel.Size.Height < 250)
                {
                    SetAnimation(quiz, quizDown);
                }
                else quizAnimtionTimer.Stop();
            }
            else
            {
                if (quizPanel.Size.Height > 50)
                {
                    SetAnimation(quiz, quizDown);
                }
                else quizAnimtionTimer.Stop();
            }
        }

        internal void setProfile()
        {
            
            string user= LoginStatusData.username;
            string name= LoginStatusData.name;
            string lname= LoginStatusData.surname;
            string email = LoginStatusData.email;
            
            usernameText.Text = user;
            firstNameText.Text = name;
            LastNameText.Text = lname;
            emailText.Text = email;
        }
    }
}
