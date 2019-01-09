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
    public partial class FeedbackControl : UserControl
    {
        private bool hasFeedbacks = false;
        private List<FeedbackHandler.Feedback> feedbackList = new List<FeedbackHandler.Feedback>();
        private List<Feedback> feedbackControls = new List<Feedback>();

        public FeedbackControl()
        {
            InitializeComponent();
        }

        private void FeedbackControl_Load(object sender, EventArgs e)
        {
            //psaxe gia feedbacks kai kane load
            Load_Feedbacks();
        }

        //pare th lista me ta feedback objects
        private void FillFeedbackList()
        {
            feedbackList = FeedbackHandler.Feedback.GetList();
        }

        //search gia feedbacks kai load
        private void Load_Feedbacks()
        {
            //kane search gia feedbacks
            FeedbackHandler.FeedbackController.SearchFeedbacks();

            //des an yparxoun feedbacks
            CheckForFeedbacks();
        }

        //tsekare an yparxoun feedbacks
        private void CheckForFeedbacks()
        {
            //des an vrhke feedbacks
            hasFeedbacks = FeedbackHandler.FeedbackController.GetHasFeedbacks();

            //an yparxoun feedbacks tote gemise 
            //to ShowFeedback panel
            if (hasFeedbacks)
            {
                showFeedbacksPanel.Controls.Clear();
                FillFeedbackList();
                SearchFeedbacks();

                noFeedback.Visible = false;
            }
            else
            {
                showFeedbacksPanel.Controls.Clear();
                showFeedbacksPanel.Controls.Add(noFeedback);
                noFeedback.Visible = true;
            }
        }

        private void SearchFeedbacks()
        {
            feedbackControls.Clear();

            Feedback temp;
            int colorCounter = 0;
            foreach (var feedback in feedbackList) {
                temp = new Feedback();
                //gia thema design
                if (colorCounter % 2 == 0)
                    temp.BackColor = Color.White;
                else
                    temp.BackColor = Color.FromName("GradientActiveCaption");
                //steile to data gia ta components
                temp.SetData(feedback.GetUserID(),feedback.GetFeedback(),feedback.GetAdminAproval());
                temp.Tag = feedback.GetFeedbackID();
                //kane add sth lista me ta feedback controls
                feedbackControls.Add(temp);

                showFeedbacksPanel.Controls.Add(temp);      //kane add to temp feedback
                colorCounter++;
            }
        }

        //gia ta checkboxes
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {   //an yparxoun feedbacks kanta ola checked gia delete
            if (feedbackList.Count > 0 && ((CheckBox)sender).Checked)
            {
                foreach (var control in feedbackControls)
                {
                    if (((CheckBox)sender).Tag.Equals("delete"))
                        control.SetDeleteCheckbox(true);
                    else
                        control.SetRateCheckbox(true);
                }
            }
            else if(feedbackList.Count > 0 && !deleteAllCheckbox.Checked)
            {
                foreach (var control in feedbackControls)
                {
                    if (((CheckBox)sender).Tag.Equals("delete"))
                        control.SetDeleteCheckbox(false);
                    else
                        control.SetRateCheckbox(false);
                }
            }else
                if (showFeedbacksPanel.Controls.ContainsKey("noFeedback"))
                MessageBox.Show("There is no Feedbacks.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //delete ena h ola ta feedbacks
        private void deleteFeedbackButton_Click(object sender, EventArgs e)
        {
            if (feedbackControls.Count > 0) {
                //rwthse gia delete
                DialogResult dialogResult = MessageBox.Show("Do you want to delete feedbacks?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //ean nai tote
                if (dialogResult == DialogResult.Yes && deleteAllCheckbox.Checked)
                {
                    FeedbackHandler.FeedbackController.DeleteFeedbacks();   //svhse ola ta feedbacks
                    feedbackControls.Clear();                               //kane clear ola ta object ths listas
                    CheckForFeedbacks();                                    //kai tsekare an yparxei allo feedback
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    var control = feedbackControls[0];
                    for(int i=0; i < feedbackControls.Count; i++)
                    {
                        if (control.GetDeleteCheckbox())
                        {
                            FeedbackHandler.FeedbackController.DeleteCheckbox(Int32.Parse((String)control.Tag.ToString()));
                        }
                        control = feedbackControls[i];
                    }
                    CheckForFeedbacks();
                }
            }else
                MessageBox.Show("There is no Feedbacks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //update ena h ola ta feedbacks
        private void UpdateFeedbackButton_Click(object sender, EventArgs e)
        {
            if (feedbackControls.Count > 0) { 
                //rwthse gia update
                DialogResult dialogResult = MessageBox.Show("Do you want to rate feedbacks?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes && UpdateAllCheckbox.Checked)
                {
                    FeedbackHandler.FeedbackController.UpdateAllCheckboxes(true); // kane update se ola
                } else if (dialogResult == DialogResult.Yes)
                {
                    var control = feedbackControls[0];
                    for (int i=0; i < feedbackControls.Count; i++)
                    {
                        if (control.GetRateCheckbox())
                        {
                            FeedbackHandler.FeedbackController.UpdateRateCheckbox(Int32.Parse((String)control.Tag.ToString()), true);
                        }
                        else
                        {
                            FeedbackHandler.FeedbackController.UpdateRateCheckbox(Int32.Parse((String)control.Tag.ToString()), false);
                        }
                        control = feedbackControls[i];
                    }
                }
            }
            else
                MessageBox.Show("There is no Feedbacks", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
