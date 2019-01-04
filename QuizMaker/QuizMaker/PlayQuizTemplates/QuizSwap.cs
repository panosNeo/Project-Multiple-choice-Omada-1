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
    public partial class QuizSwap : UserControl
    {
        public int PositionCounter { get; set; }
        public bool Answered { get; set; }
        public QuizSwap(int pos)
        {
            
            InitializeComponent();
            PositionCounter = pos;
            SetButtonTag();
        }
        private void SetButtonTag()
        {
            questionBtn.Tag = PositionCounter;
        }
        public void SetButtonColor(Color c)
        {
            questionBtn.BackColor = c;
        }
    }
}
