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
    public partial class FirstPage : UserControl
    {
        public FirstPage()
        {
            InitializeComponent();
            questionsPanel.Visible = true;
            //questionsPanel.Controls.Add(new PrintQuestion());
        }

        public void setTitle(string t)
        {
            titleLabel.Text = t;
        }

        public Size GetQuestionsSize()
        {
            return questionsPanel.Size;
        }

        public void SetControlInQuestions(Point p, UserControl c)
        {
            c.Location = p;
            questionsPanel.Controls.Add(c);
            c.Visible = true;
        }
    }
}
