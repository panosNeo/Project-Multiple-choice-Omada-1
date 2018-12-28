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
        private int positionCounter;
        public int PositionCounter
        {
            get => positionCounter;
            set => positionCounter = value;
        }
        public QuizSwap()
        {
            InitializeComponent();
        }

        public void SetButtonColor(Color c)
        {
            questionBtn.BackColor = c;
        }
    }
}
