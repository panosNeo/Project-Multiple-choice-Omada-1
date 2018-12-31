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
    public partial class PrintQuestion : UserControl
    {
        public PrintQuestion()
        {
            InitializeComponent();
        }
        public void SetTitle(string t)
        {
            questionTitle.Text = t;
        }
        
    }
}
