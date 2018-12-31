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
    public partial class NextPage : UserControl
    {
        public NextPage()
        {
            InitializeComponent();
        }
        public Size GetQuestionsSize()
        {
            return Size;
        }

        public void SetControlInQuestions(Point p, Control c)
        {
            c.Location = p;
            Controls.Add(c);
        }
    }
}
