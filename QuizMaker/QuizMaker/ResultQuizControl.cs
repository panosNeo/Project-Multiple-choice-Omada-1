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
    public partial class ResultQuizControl : UserControl
    {
        public Quiz Quiz;
        public ResultQuizControl(Quiz q)
        {
            Quiz = q;
            InitializeComponent();
        }
        public Quiz GetQuiz()
        {
            return Quiz;
        }

        public void SetColor(Color c)
        {
            this.BackColor = c;
            quizTitleText.BackColor = c;
            quizSubjectText.BackColor = c;
            questionCountText.BackColor = c;
            likesText.BackColor = c;
            dislikesText.BackColor = c;
        }
        public void SetQuizTitle(string title)
        {
            quizTitleText.Text = title;
        }
        public void SetQuizSubject(string title)
        {
            quizSubjectText.Text = title;
        }
        public void SetQuizNumberOfQuestions(int title)
        {
            questionCountText.Text = Convert.ToString(title);
        }
        public void SetQuizLikes(int title)
        {
            likesText.Text = Convert.ToString(title);
        }
        public void SetQuizDislikes(int title)
        {
            dislikesText.Text = Convert.ToString(title);
        }
    }
}
