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
    public partial class ReportControl : UserControl
    {
        private bool hasReports = false;
        private List<ReportHandler.Report> reportList = new List<ReportHandler.Report>();
        private List<Report> reportControls = new List<Report>();

        public ReportControl()
        {
            InitializeComponent();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            //psaxe gia reports
            Load_Reports();
        }

        private void Load_Reports()
        {
            //kane search gia reports
            ReportHandler.ReportController.SearchForReports();

            //des an uparxoun reports
            CheckForReports();
        }

        public void CheckForReports()
        {
            //des an vrhke report
            hasReports = ReportHandler.ReportController.GetHasReports();

            //an uparxoun reports
            //tote gemise to report panel
            if (hasReports)
            {
                showReportsPanel.Controls.Clear();

                FillReportList();
                SearchReports();

                noReports.Visible = false;
            }
            else
            {
                showReportsPanel.Controls.Clear();
                showReportsPanel.Controls.Add(noReports);
                noReports.Visible = true;
            }
        }

        private void SearchReports()
        {
            reportControls.Clear();

            Report temp;
            int colorCounter = 0;
            foreach (var report in reportList)
            {
                temp = new Report();
                if (colorCounter % 2 == 0)
                    temp.BackColor = Color.White;
                else
                    temp.BackColor = Color.FromName("GradientActiveCaption");
                //steile to data sta components
                temp.SetData(report.GetUserID(),report.GetReport(),report.GetQuizID());
                temp.Tag = report.GetReportID();

                //prosthese to event gia na fortwseis to quiz data
                temp.Click += new EventHandler(clicked);

                //kane add sth lista me ta controls
                reportControls.Add(temp);

                showReportsPanel.Controls.Add(temp);    //kane add sto panel 
                colorCounter++;
            }
        }
        //?
        private void loadReports()
        {
            reportControls.Clear();
            Report temp;
            for(int i = 0; i < 11; i++)
            {
                temp = new Report();
                if (i % 2 == 0)
                    temp.BackColor = Color.White;
                else
                    temp.BackColor = Color.FromName("GradientActiveCaption");
                
                temp.Tag = i;

                reportControls.Add(temp);

                showReportsPanel.Controls.Add(temp);
            }
        }
        private void clicked(object sender, EventArgs e) {
            MessageBox.Show(((Report)sender).Tag.ToString());
        }

        //pare th lista me ta reports
        private void FillReportList()
        {
            reportList = ReportHandler.Report.GetList();
        }

        //?
        private void Test()
        {
            showReportsPanel.Controls.Clear();
            foreach (var control in reportControls)
            {
                showReportsPanel.Controls.Add(control);
            }
        }


        //design sta buttons
        private void deleteReportButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }
        private void deleteReportButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromName("GradientActiveCaption");
        }

        //delete checkbox leitourgies
        private void deleteAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (reportControls.Count > 0 && deleteAllCheckbox.Checked)
            {   //kane true ola te delete checkboxes
                foreach (var control in reportControls)
                {
                    control.SetDeleteCheckbox(true);
                }
                //kane update kai sthn database to field delete
                ReportHandler.ReportController.UpdateAllDeleteCheckboxes(true);
            }
            else if (reportControls.Count > 0 && !deleteAllCheckbox.Checked)
            {
                foreach (var control in reportControls)
                {
                    control.SetDeleteCheckbox(false);
                }
                ReportHandler.ReportController.UpdateAllDeleteCheckboxes(false);
            }
            else
            {
                showReportsPanel.Controls.Add(noReports);
                noReports.Visible = true;
                MessageBox.Show("There is no Reports.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
                if (reportControls.Count > 0)
                {
                    //rwthse gia delete
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete reports?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //ean nai tote
                    if (dialogResult == DialogResult.Yes && deleteAllCheckbox.Checked)
                    {
                        //FeedbackHandler.FeedbackController.DeleteFeedbacks();   //svhse ola ta feedbacks
                        //feedbackControls.Clear();                               //kane clear ola ta object ths listas
                        reportControls.Clear();
                        showReportsPanel.Controls.Clear();
                    }
                    else if (dialogResult == DialogResult.Yes)
                    {
                        var control = reportControls[0];
                        for (int i=0; i < reportControls.Count; i++)
                        {
                            if (control.GetDeleteCheckbox())
                            {
                                reportControls.Remove(control);
                            }
                            control = reportControls[i];
                        }
                        Test();
                    }
                }
                else
                    MessageBox.Show("There is no reports.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
