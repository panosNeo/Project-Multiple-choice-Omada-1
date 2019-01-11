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

        private List<int> questionIDs = new List<int>();
        private List<string> questions = new List<string>();
        private static List<int> answerIDList = new List<int>();
        private static List<string> answers = new List<string>();

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

            showReportsPanel.Controls.Clear();
            //an uparxoun reports
            //tote gemise to report panel
            if (hasReports)
            {
                FillReportList();
                SearchReports();

                noReports.Visible = false;
            }
            else
            {
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
        //gia na fortothoun ta dedomena sto quiz data
        private void clicked(object sender, EventArgs e) {           
            //katharise tis listes prin apo kathe search
            ReportHandler.ReportController.ClearLists();
            ReportHandler.ReportController.ClearQuestion_AnswerList();
            questionIDs.Clear();
            questions.Clear();
            answerIDList.Clear();
            answers.Clear();

            //psaxe an uparxei to quiz pou ekane report
            ReportHandler.ReportController.SearchReport_Quiz(Int32.Parse(((Report)sender).Tag.ToString()));
            //pare tis metavlhtes me tis times apo to parapanw search
            int quizID = ReportHandler.ReportController.GetQuizID();
            string quiz_title = ReportHandler.ReportController.GetQuizTitle();
            int by_user = ReportHandler.ReportController.GetByUser();
            //vale to quiz title kai ton user pou eftiaxe to quiz
            QuizNameBox.Text = quiz_title;
            qUserIDBox.Text = by_user.ToString();


            if (quizID != -1)
            {
                //kane search gia ta questions tou quiz
                ReportHandler.ReportController.SearchQuiz_Question(quizID);
                //pare tis listes
                questionIDs = ReportHandler.ReportController.GetQuestionIDList();
                questions = ReportHandler.ReportController.GetQuestionsList();
                //kane fill ta IDs
                questionIDCombo.Items.Clear();
                foreach (var question_id in questionIDs)
                {
                    questionIDCombo.Items.Add(question_id);
                }
                if (questionIDs.Count > 0)
                {
                    questionIDCombo.SelectedIndex = 0;
                    qQuestionBox.Text = questions[0];
                }
            }
            else
            {
                questionIDCombo.Items.Clear();
            }
        }

        //pare th lista me ta reports
        private void FillReportList()
        {
            reportList = ReportHandler.Report.GetList();
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
            }
            else if (reportControls.Count > 0 && !deleteAllCheckbox.Checked)
            {
                foreach (var control in reportControls)
                {
                    control.SetDeleteCheckbox(false);
                }
            }
            else
            {
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
                    ReportHandler.ReportController.DeleteAllReports();
                    ReportHandler.Report.ClearList();
                    reportControls.Clear();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    Report control;
                    for (int i = 0; i < reportControls.Count; i++)
                    {
                        control = reportControls[i];
                        if (control.GetDeleteCheckbox())
                        {
                            ReportHandler.ReportController.DeleteOneReport(Int32.Parse((String)control.Tag.ToString()));
                        }
                    }
                }
                Load_Reports();
            }
            else
                MessageBox.Show("There is no reports.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        //otan allazei ena id fortwse to antistoixo question kai ta answers pou exei
        private void questionIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = questionIDCombo.SelectedIndex;
            qQuestionBox.Text = questions[position];

            //psaxe gia ta answers tou antistoixou question
            ReportHandler.ReportController.SearchQuestion_Answer(questionIDs[position]);
            //gemise tis listes
            answerIDList = ReportHandler.ReportController.GetAnswerIDList();
            answers = ReportHandler.ReportController.GetAnswers();
            //kai kane fill ta IDs 
            if (answerIDList.Count > 0)
            {
                answerIDCombo.Items.Clear();
                foreach (var answer_id in answerIDList)
                {
                    answerIDCombo.Items.Add(answer_id);
                }
                answerIDCombo.SelectedIndex = 0;
                AnswerBox.Text = answers[0];
            }
        }

        private void answerIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = answerIDCombo.SelectedIndex;
            AnswerBox.Text = answers[position];
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tap to any Report to load quiz data.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
