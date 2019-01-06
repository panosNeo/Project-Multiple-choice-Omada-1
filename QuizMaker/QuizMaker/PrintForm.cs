using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.PrintQuizTemplates;

namespace QuizMaker
{
    public partial class PrintForm : Form
    {
        private List<FirstPage> first;
        public PrintForm(List<FirstPage> f)
        {
            InitializeComponent();
            first = f;
            foreach (FirstPage fi in first)
            {
                this.Controls.Add(fi);
                fi.Visible = true;
            }
        }

        public List<FirstPage> First { get => first; set => first = value; }
    }
}
