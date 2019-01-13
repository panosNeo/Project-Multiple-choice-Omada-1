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
    public partial class ReportPanel : UserControl
    {
        private int q_id;
        int userId = Login.Login.userID;
        public ReportPanel(int quiz_id)
        {
            InitializeComponent();
            q_id = quiz_id;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string report = reportText.Text;
            MultipleChoiceDataSetTableAdapters.ReportTableAdapter reportTableAdapter = new MultipleChoiceDataSetTableAdapters.ReportTableAdapter();
            reportTableAdapter.InsertReport(userId, report, q_id);
            MessageBox.Show("Thanks you for your Report");
            Controls.Clear();
        }
    }
}
