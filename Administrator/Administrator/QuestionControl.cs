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
    public partial class QuestionControl : UserControl
    {
        public QuestionControl()
        {
            InitializeComponent();
        }

        //settings button gia energopoihsh - apenergopoihsh sta components 
        private void QuestionSettingsButton_Click(object sender, EventArgs e)
        {
            if (UserIDBox.ReadOnly)
            {
                UserIDBox.ReadOnly = false;
                SubjectIDBox.ReadOnly = false;
                QuestionBox.ReadOnly = false;
                RatingBox.ReadOnly = false;
                DateBox.ReadOnly = false;
                AnswerBox.ReadOnly = false;
                QuestionIDBox.ReadOnly = false;

                CorrectCheckbox.Enabled = true;
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;
                UpdateButton.Enabled = true;
                QuestionReset.Enabled = true;
            }
            else
            {
                UserIDBox.ReadOnly = true;
                SubjectIDBox.ReadOnly = true;
                QuestionBox.ReadOnly = true;
                RatingBox.ReadOnly = true;
                DateBox.ReadOnly = true;
                AnswerBox.ReadOnly = true;
                QuestionIDBox.ReadOnly = true;

                CorrectCheckbox.Enabled = false;
                AddButton.Enabled = false;
                DeleteButton.Enabled = false;
                UpdateButton.Enabled = false;
                QuestionReset.Enabled = false;
            }
        }

        private void QuestionReset_Click(object sender, EventArgs e)
        {
            UserIDBox.Text = "";
            SubjectIDBox.Text = "";
            QuestionBox.Text = "";
            RatingBox.Text = "";
            DateBox.Text = "";
            AnswerBox.Text = "";
            QuestionIDBox.Text = "";
        }
    }
}
