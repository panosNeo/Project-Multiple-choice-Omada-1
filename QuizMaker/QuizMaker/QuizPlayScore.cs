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
    public partial class QuizPlayScore : UserControl
    {
        public QuizPlayScore(string score)
        {
            InitializeComponent();
            this.score.Text = score;
        }
    }
}
