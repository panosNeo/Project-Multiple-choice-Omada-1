using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.QuizHandler;

namespace QuizMaker
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            setProfile();
            setUserQuizes();
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
                if (personalPanel.Size.Height < 300)
                {
                    SetAnimation(personal, personalDown);
                }
                else personalAnimationTimer.Stop();
            }
            else
            {
                if (personalPanel.Size.Height > 60)
                {
                    SetAnimation(personal, personalDown);
                }
                else personalAnimationTimer.Stop();
            }
        }
        private void setUserQuizes()
        {
            ResultQuizControl temp;
            int counter = 0;
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            foreach (Quiz q in SearchHandler.SearchController.GetQuizByUserID(LoginStatusData.userID))
            {
                
                temp = new ResultQuizControl(q);
                temp.Dock = DockStyle.Top;
                if(counter%2 == 0)
                {
                    temp.SetColor(Color.FromArgb(37, 46, 69));
                }
                counter++;
                temp.SetQuizNumberOfQuestions(q.getQuestions().Count);
                temp.SetQuizTitle(q.GetQuizTitle());
                temp.SetQuizSubject(subject.GetSubjectName(q.GetSubject_id()));
                temp.Click += new EventHandler(ResultQuiz_Click);
                quizPanel.Controls.Add(temp);
            }
        }
        private void ResultQuiz_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            QuizPanel p = new QuizPanel(new QuizPlayerController(((ResultQuizControl)sender).GetQuiz()));
            p.Dock = DockStyle.Fill;
            Controls.Add(p);
        }
        private void SetAnimation(string panel, bool down)
        {
            if(panel == "personal")
            {
                if (down)
                {
                    personalPanel.Size = new Size(personalPanel.Size.Width, personalPanel.Size.Height + 10);
                    quizPanel.Location = new Point(quizPanel.Location.X, quizPanel.Location.Y + 10);
                    quizBtn.Location = new Point(quizBtn.Location.X, quizBtn.Location.Y + 10);
                }
                else
                {
                    personalPanel.Size = new Size(personalPanel.Size.Width, personalPanel.Size.Height - 10);
                    quizPanel.Location = new Point(quizPanel.Location.X, quizPanel.Location.Y - 10);
                    quizBtn.Location = new Point(quizBtn.Location.X, quizBtn.Location.Y - 10);
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
                quizPanel.AutoScroll = true;
                ((Button)sender).Tag = "-";
            }
            else
            {
                quizDown = false;
                quizPanel.AutoScroll = false;
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
                if (quizPanel.Size.Height > 0)
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string name = firstNameText.Text;
            string lname = LastNameText.Text;
            string email = emailText.Text;
            int userId = Login.Login.userID;
            
            MultipleChoiceDataSetTableAdapters.UserTableAdapter userTable = new MultipleChoiceDataSetTableAdapters.UserTableAdapter();
            userTable.UpdateProfile(user, email, name, lname, userId);

            LoginStatusData.userID = userId;
            LoginStatusData.username = user;
            LoginStatusData.name = name;
            LoginStatusData.surname = lname;
            LoginStatusData.email = email;

        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            FeedbackControl f = new FeedbackControl();
            f.Dock = DockStyle.Fill;
            Controls.Add(f);
        }
    }
}
