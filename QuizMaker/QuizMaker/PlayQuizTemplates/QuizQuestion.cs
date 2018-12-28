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
    public partial class QuizQuestion : UserControl
    {
        public QuizQuestion()
        {
            InitializeComponent();
        }

        public void setQuestion(string num, string question)
        {
            questionLabel.Text = question;
            questionNumLabel.Text = num + ")";
        }
    }
}
