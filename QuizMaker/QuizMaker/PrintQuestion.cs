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
    public partial class PrintQuestion : UserControl
    {
        public PrintQuestion()
        {
            InitializeComponent();
        }

        public void setQuestionText(string text, int answerNum)
        {
            switch (answerNum)
            {
                case 1:
                    answer1.Text = text;
                    break;
                case 2:
                    answer2.Text = text;
                    break;
                case 3:
                    answer3.Text = text;
                    break;
                case 4:
                    answer4.Text = text;
                    break;
            }
            foreach(Label l in this.Controls)
            {
                if(l.Text == "undefined")
                {
                    l.Visible = false;
                }
            }
        }

        public void setTitle(string title)
        {
            QuestionNameLabel.Text = title;
        }
    }
}
