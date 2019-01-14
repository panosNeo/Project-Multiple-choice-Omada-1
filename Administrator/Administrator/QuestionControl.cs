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

        private static List<int> answerIDList;
        private static List<string> answers;
        private static List<bool> correctList;

        private string question = "";

        public QuestionControl()
        {
            InitializeComponent();
        }

        //settings button gia energopoihsh - apenergopoihsh sta components 
        private void QuestionSettingsButton_Click(object sender, EventArgs e)
        {
            if (QuestionBox.ReadOnly)
            {
                QuestionBox.ReadOnly = false;
                AnswerBox.ReadOnly = false;

                CorrectCheckbox.Enabled = true;
                DeleteButton.Enabled = true;
                UpdateButton.Enabled = true;
                QuestionReset.Enabled = true;
            }
            else
            {
                AnswerBox.ReadOnly = true;
                QuestionBox.ReadOnly = true;

                CorrectCheckbox.Enabled = false;
                DeleteButton.Enabled = false;
                UpdateButton.Enabled = false;
                QuestionReset.Enabled = false;
            }
        }
        //reset ta textboxes
        private void QuestionReset_Click(object sender, EventArgs e)
        {
            UserIDBox.Text = "";
            SubjectIDBox.Text = "";
            QuestionBox.Text = "";
            RatingBox.Text = "";
            DateBox.Text = "";
            AnswerBox.Text = "";
            QuestionIDBox.Text = "";

            AnswerIDCombo.Items.Clear();
            AnswerIDCombo.Text = "";
        }

        //psaxe gia answers kai kane fill ta IDs
        private void SearchAnswers()
        {
            //psaxe gia answers
            QuestionHandler.QuestionController.SearchAnswers();

            answerIDList = new List<int>();
            answerIDList = QuestionHandler.QuestionController.GetAnswerIDs();
            answers = new List<string>();
            answers = QuestionHandler.QuestionController.GetAnswers();
            correctList = new List<bool>();
            correctList = QuestionHandler.QuestionController.GetCorrectList();


            AnswerIDCombo.Items.Clear();
            if (answerIDList.Count > 0)
            {
                noAnswers.Visible = false;

                foreach (var id in answerIDList)
                {
                    AnswerIDCombo.Items.Add(id);
                }
                AnswerIDCombo.SelectedIndex = 0;
                AnswerBox.Text = answers[0];
                CorrectCheckbox.Checked = correctList[0];
            }
            else
            {
                noAnswers.Text = "No existing Answers.";
                noAnswers.Visible = true;
            }
        }
        
        private void SearchBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SearchIDBox.Text))
                {
                    warningLabel.Text = "Please input question id.";
                    warningLabel.Visible = true;
                }
                else
                {
                    warningLabel.Visible = false;
                    if (QuestionHandler.QuestionController.SearchQuestionID(Int32.Parse(SearchIDBox.Text)))
                    {
                        QuestionIDBox.Text = QuestionHandler.QuestionController.question_id.ToString();
                        QuestionBox.Text = QuestionHandler.QuestionController.question;
                        DateBox.Text = QuestionHandler.QuestionController.cr_date;
                        SubjectIDBox.Text = QuestionHandler.QuestionController.subject_id.ToString();
                        UserIDBox.Text = QuestionHandler.QuestionController.username;
                        RatingBox.Text = QuestionHandler.QuestionController.rating.ToString();

                        question = QuestionHandler.QuestionController.question;

                        SearchAnswers(); //psaxe gia answers 
                    }
                    else
                    {
                        AnswerIDCombo.Items.Clear();
                        AnswerIDCombo.Text = "";
                        warningLabel.Text = "Question does not exist.";
                        warningLabel.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                warningLabel.Text = "Wrong input.";
                warningLabel.Visible = true;
            }
        }

        private void AnswerIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (answerIDList.Count > 0)
            {
                int position = AnswerIDCombo.SelectedIndex;
                AnswerBox.Text = answers[position];
                CorrectCheckbox.Checked = correctList[position];
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrWhiteSpace(SearchIDBox.Text))
                {
                    warningLabel.Text = "Please input question id.";
                    warningLabel.Visible = true;
                }
                else
                {
                    warningLabel.Visible = false;
                    DialogResult check = MessageBox.Show("Do you want to delete this question?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (check == DialogResult.Yes)
                    {
                        QuestionHandler.QuestionController.DeleteQuestion(Int32.Parse(SearchIDBox.Text));
                    }
                }
            } catch (Exception)
            {
                warningLabel.Text = "Wrong input.";
                warningLabel.Visible = true;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SearchIDBox.Text))
                {
                    warningLabel.Text = "Please input question id.";
                    warningLabel.Visible = true;
                }
                else
                {
                    if (!question.Equals(QuestionBox.Text))
                    {
                        DialogResult check = MessageBox.Show("Do you want to update question?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (check == DialogResult.Yes)
                        {
                            QuestionHandler.QuestionController.UpdateQuestion(Int32.Parse(SearchIDBox.Text), QuestionBox.Text);
                        }
                    }
                    if (!AnswerBox.Text.Equals(answers[AnswerIDCombo.SelectedIndex]) || CorrectCheckbox.Checked != correctList[AnswerIDCombo.SelectedIndex])
                    {
                        DialogResult check = MessageBox.Show("Do you want to update answer?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (check == DialogResult.Yes)
                        {
                            QuestionHandler.QuestionController.UpdateAnswer(answerIDList[AnswerIDCombo.SelectedIndex],AnswerBox.Text,CorrectCheckbox.Checked);
                        }
                    }
                }
            }
            catch (Exception)
            {
                warningLabel.Text = "Wrong input.";
                warningLabel.Visible = true;
            }
        }
    }
}
