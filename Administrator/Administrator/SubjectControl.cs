using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class SubjectControl : UserControl
    {

        public SubjectControl()
        {
            InitializeComponent();
        }

        private void QuizSettingsButton_Click(object sender, EventArgs e)
        {
            //kane enabled kai readOnly ta components
            if (qSubIDBox.ReadOnly)
            {
                qSubIDBox.ReadOnly = false;
                qQuizIDBox.ReadOnly = false;
                qUserIDBox.ReadOnly = false;
                qQuizNameBox.ReadOnly = false;
                qDateBox.ReadOnly = false;

                QuizAdd.Enabled = true;
                QuizDelete.Enabled = true;
                QuizUpdate.Enabled = true;
                QuizReset.Enabled = true;
            }
            else
            {
                qSubIDBox.ReadOnly = true;
                qQuizIDBox.ReadOnly = true;
                qUserIDBox.ReadOnly = true;
                qQuizNameBox.ReadOnly = true;
                qDateBox.ReadOnly = true;

                QuizAdd.Enabled = false;
                QuizDelete.Enabled = false;
                QuizUpdate.Enabled = false;
                QuizReset.Enabled = false;
            }
        }

        private void QuizReset_Click(object sender, EventArgs e)
        {
            qSubIDBox.Text = "";
            qQuizIDBox.Text = "";
            qUserIDBox.Text = "";
            qQuizNameBox.Text = "";
            qDateBox.Text = "";
        }
    }
}
