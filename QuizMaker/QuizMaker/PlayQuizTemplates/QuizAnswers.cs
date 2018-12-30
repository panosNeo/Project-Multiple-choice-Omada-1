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
        private int questionNum;
        private int answerNum;
        public QuizAnswers(int questionNum, int answerNum)
        {
            InitializeComponent();
            this.questionNum = questionNum;
            this.answerNum = answerNum;
        }
        
        public bool getAnswer()
        {
            return answerBox.Checked;
        }
        public int getQuestionNum()
        {
            return questionNum;
        }
        public int getAnswerNum()
        {
            return answerNum;
        }
        public void setAnswer(string num, string question)
        {
            answerLabel.Text = question;
            answerNumLabel.Text = num + ")";
        }
    }
}
