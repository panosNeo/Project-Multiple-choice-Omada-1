using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.PrintQuizTemplates
{
    public partial class QuestionAnswer : UserControl
    {
        public QuestionAnswer(string t)
        {
            InitializeComponent();
            question1.Text = t;
        }

        
    }
}
