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
    public partial class FeedbackControl : UserControl
    {
        public FeedbackControl()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MultipleChoiceDataSetTableAdapters.FeedbackTableAdapter f = new MultipleChoiceDataSetTableAdapters.FeedbackTableAdapter();
            f.InsertQuery(LoginStatusData.userID, feedbackText.Text);
            Controls.Clear();
            Controls.Add(new ProfileControl {
            Dock = DockStyle.Fill});
            MessageBox.Show("Thank you for sharing your feedback!");
        }
    }
}
