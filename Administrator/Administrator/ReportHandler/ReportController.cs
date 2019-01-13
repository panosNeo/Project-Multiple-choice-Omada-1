using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.ReportHandler
{
    static class ReportController
    {
        //gia to search kai to update twn reports
        private static string searchForReports = "Select Report_id,User_id,Quiz_id,Question_id,Report From Report;";
        private static string deleteOne = "Delete From Report Where Report_id = ?;";
        private static string deleteAll = "Delete From Report;";

        //gia to quiz data
        private static string report_quiz = "Select Quiz.Quiz_id,Quiz.Title,[User].[Username],Subject.S_name From (((Report inner join Quiz on Report.Quiz_id = Quiz.Quiz_id) inner join [User] on Quiz.By_user = [User].User_id) inner join Subject on Quiz.Subject_id = Subject.Subject_id) Where Report.Report_id = ?;";
        private static string quiz_question = "Select Question.Question_id,Question.Question From Quiz inner join Question on Quiz.Quiz_id = Question.Quiz_id Where Quiz.Quiz_id = ?;";
        private static string question_answer = "Select Answer.Answer_id,Answer.Answer From Question inner join Answer on Question.Question_id = Answer.Question_id Where Question.Question_id = ?;";

        //methods-objects-variables gia to quiz data
        //      metavlhtes gia to report - quiz
        private static string quizTitle = "Not found";
        private static int quizID = -1;
        private static string username = "Not found";
        private static string subject_name = "Not found";
        //      metavlhtes gia to quiz - question
        private static List<int> questionIDList = new List<int>();
        private static List<string> questionsList = new List<string>();
        //      metavlhtes gia to question - answer
        private static List<int> answerIDList = new List<int>();
        private static List<string> answers = new List<string>();

        //methods gia to quiz - question
        public static List<int> GetQuestionIDList()
        {
            return questionIDList;
        }
        public static List<string> GetQuestionsList()
        {
            return questionsList;
        }
        public static void ClearQuiz_Question()
        {
            questionsList.Clear();
            questionIDList.Clear();
        }

        //methods gia to question - answer
        public static List<int> GetAnswerIDList()
        {
            return answerIDList;
        }
        public static List<string> GetAnswers()
        {
            return answers;
        }
        public static void ClearQuestion_AnswerList()
        {
            answerIDList.Clear();
            answers.Clear();
        }

        //getters gia to data report - quiz
        public static string GetQuizTitle()
        {
            return quizTitle;
        }
        public static int GetQuizID()
        {
            return quizID;
        }
        public static string GetUsername()
        {
            return username;
        }
        public static string GetSubjectName()
        {
            return subject_name;
        }
        
        //vres ta report - quiz
        public static bool SearchReport_Quiz(int report_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@report_quiz, conn))
                    {
                        bool check = false;
                        conn.Open();
                        searchCommand.Parameters.AddWithValue("@p1",report_id);
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            if (searchReader.HasRows)
                            {
                                int countRows = 0;
                                while (searchReader.Read())
                                {
                                    countRows++;

                                    quizID = searchReader.GetInt32(0);
                                    quizTitle = searchReader.GetString(1);
                                    username = searchReader.GetString(2);
                                    subject_name = searchReader.GetString(3);
                                    check = true;
                                }
                                if (countRows != 1)
                                {
                                    quizID = -1;
                                    quizTitle = "Not found";
                                    username = "Not found";
                                    subject_name = "Not found";
                                }
                            }
                            searchReader.Close();
                        }
                        conn.Close();
                        return check;
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //vres to question kai to question_id
        public static bool SearchQuiz_Question()
        {
            ClearQuiz_Question();   //katharise tis listes prin apo kathe search
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@quiz_question, conn))
                    {
                        bool check = false;
                        conn.Open();
                        searchCommand.Parameters.AddWithValue("@p1", quizID);
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            while (searchReader.Read())
                            {
                                questionIDList.Add(searchReader.GetInt32(0));
                                questionsList.Add(searchReader.GetString(1));
                                check = true;
                            }
                            searchReader.Close();
                        }
                        conn.Close();
                        return check;
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //vres to answer id kai to answer ths erwthshs
        public static void SearchQuestion_Answer(int question_id)
        {
            ClearQuestion_AnswerList();
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@question_answer, conn))
                    {
                        conn.Open();
                        searchCommand.Parameters.AddWithValue("@p1", question_id);
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            while (searchReader.Read())
                            {
                                answerIDList.Add(searchReader.GetInt32(0));
                                answers.Add(searchReader.GetString(1));
                            }
                            searchReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //methods kai objects gia search kai update twn reports
        //
        private static bool hasReports = false; //an yparxoun reports tote true
        private static Report report;
        //psaxe gia reports
        public static void SearchForReports()
        {
            Report.ClearList(); //kane clear th lista prin apo kathe search
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@searchForReports, conn))
                    {
                        conn.Open();
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            if (searchReader.HasRows)
                            {
                                hasReports = true;
                                while (searchReader.Read())
                                {   //ftiaxe to report
                                    report = new Report(searchReader.GetInt32(0),searchReader.GetInt32(1),searchReader.GetInt32(2),searchReader.GetInt32(3),searchReader.GetString(4));
                                    //kai kane to add sth lista
                                    Report.Add(report);
                                }
                            }
                            else
                                hasReports = false;

                            searchReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //an uparxei report epestrepse true
        public static bool GetHasReports()
        {
            return hasReports;
        }
        //kane delete ola osa einai true
        public static void DeleteOneReport(int report_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteOne, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",report_id);
                        //datareader
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane delete ola ta reports
        public static void DeleteAllReports()
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteAll, conn))
                    {
                        conn.Open();
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            Report.ClearList();   //adeiase th lista
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
