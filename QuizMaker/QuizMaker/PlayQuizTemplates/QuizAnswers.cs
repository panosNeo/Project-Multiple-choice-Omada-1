using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.PlayQuizTemplates
{
    public partial class QuizAnswers : UserControl
    {
        public QuizAnswers()
        {
            InitializeComponent();
        }

        public bool getAnswer()
        {
            return answerBox.Checked;
        }

        public void setAnswer(string num, string question)
        {
            answerLabel.Text = question;
            answerNumLabel.Text = num + ")";
        }
    }
}
