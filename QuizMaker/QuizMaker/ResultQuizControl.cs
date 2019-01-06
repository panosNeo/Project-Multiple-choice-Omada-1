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
    public partial class ResultQuizControl : UserControl
    {
        public ResultQuizControl()
        {
            InitializeComponent();
        }
        private void SetQuizTitle(string title)
        {
            quizTitleText.Text = title;
        }
        private void SetQuizSubject(string title)
        {
            quizSubjectText.Text = title;
        }
        private void SetQuizNumberOfQuestions(string title)
        {
            questionCountText.Text = title;
        }
        private void SetQuizLikes(string title)
        {
            likesText.Text = title;
        }
        private void SetQuizDislikes(string title)
        {
            dislikesText.Text = title;
        }
    }
}
