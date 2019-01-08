using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.ReportHandler
{
    class Report
    {
        private int report_id;
        private int user_id;
        private int quiz_id;
        private int question_id;
        private string report;
        private bool forDelete;

        private static List<Report> reportList = new List<Report>();

        public Report(int report_id,int user_id,int quiz_id,int question_id,string report,bool forDelete)
        {
            this.report_id = report_id;
            this.user_id = user_id;
            this.quiz_id = quiz_id;
            this.question_id = question_id;
            this.report = report;
            this.forDelete = forDelete;
        }

        public void SetReportID(int report_id)
        {
            this.report_id = report_id;
        }
        public int GetReportID()
        {
            return report_id;
        }

        public void SetUserID(int user_id)
        {
            this.user_id = user_id;
        }
        public int GetUserID()
        {
            return user_id;
        }

        public void SetQuizID(int quiz_id)
        {
            this.quiz_id = quiz_id;
        }
        public int GetQuizID()
        {
            return quiz_id;
        }

        public void SetQuestionID(int question_id)
        {
            this.question_id = question_id;
        }
        public int GetQuestionID()
        {
            return question_id;
        }

        public void SetReport(string report)
        {
            this.report = report;
        }
        public string GetReport()
        {
            return report;
        }

        public void SetForDelete(bool forDelete)
        {
            this.forDelete = forDelete;
        }
        public bool GetForDelete()
        {
            return forDelete;
        }

        public string PrintData()
        {
            return report_id + " " + user_id + " " + quiz_id + " " + question_id + " " +report + " " + forDelete;
        }


        //methods gia to report list
        //
        //add ena report 
        public static void Add(Report report)
        {
            try
            {
                //checkare gia diplotypo
                bool checkForDuplicate = reportList.Contains(report);

                if (checkForDuplicate)
                    MessageBox.Show("The report already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    reportList.Add(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //delete ena report
        public static void Delete(Report report)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = reportList.Contains(report);

                if (checkIfexist)
                    reportList.Remove(report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //katharise th lista
        public static void ClearList()
        {
            reportList.Clear();
        }
        //pare th lista
        public static List<Report> GetList()
        {
            return reportList;
        }

    }
}
