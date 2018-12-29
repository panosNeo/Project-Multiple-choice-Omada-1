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
    public partial class AnswerPanel : UserControl
    {
        public AnswerPanel()
        {
            InitializeComponent();
        }

        public string GetAnswerName()
        {
            return AnswerText.Text;
        }

        public bool GetCorrection()
        {
            return correctCheckBox.Checked;
        }

        public void SetAnswerName(string answerName)
        {
            AnswerText.Text = answerName;
        }
        public void SetCorrection(bool check)
        {
            correctCheckBox.Checked = check;
        }
    }
}
