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
        private static string searchForReports = "Select Report_id,User_id,Quiz_id,Question_id,Report,Delete From Report;";
        private static string deleteOne = "Delete From Report Where Report_id = ?;";
        private static string deleteAll = "Delete From Report;";
        private static string updateAlldel = "Update Report Set Delete = ?;";
        private static string updateOneDel = "Update Report Set Delete = ? Where Report_id = ?;";

        //gia to quiz data
        private static string report_quiz = "Select Quiz.Quiz_id,Quiz.Title,Quiz.By_user From Report inner join Quiz on Report.Quiz_id = Quiz.Quiz_id Where Report.Report_id = ?;";
        private static string quiz_question = "Select Question.Question_id,Question.Question From Quiz inner join Question on Quiz.Quiz_id = Question.Quiz_id Where Quiz.Quiz_id = ?;";
        private static string question_answer = "Select Answer.Answer_id,Answer.Answer From Question inner join Answer on Question.Question_id = Answer.Question_id Where Question.Question_id = ?;";

        //methods-objects-variables gia to quiz data
        //      metavlhtes gia to report - quiz
        private static string quizTitle = "Nothing";
        private static int quizID = -1;
        private static int by_user = -1;
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
        public static void ClearLists()
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
        public static int GetByUser()
        {
            return by_user;
        }
        
        //vres ta quiz_title,quiz_id,by_user
        public static void SearchReport_Quiz(int report_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@report_quiz, conn))
                    {
                        conn.Open();
                        searchCommand.Parameters.AddWithValue("@p1",report_id);
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            if (searchReader.HasRows)
                            {
                                //metra ta records pou vre8hkan
                                int countRows = 0;
                                while (searchReader.Read())
                                {
                                    countRows++;
                                }

                                //kai an einai = 1
                                //tote kane set to data pou vre8hke stis metavlhtes
                                if (countRows == 1)
                                {
                                    quizID = searchReader.GetInt32(0);
                                    quizTitle = searchReader.GetString(1);
                                    by_user = searchReader.GetInt32(2);
                                }
                                else
                                {
                                    quizID = -1;
                                    quizTitle = "Nothing";
                                    by_user = -1;
                                }
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
        //vres to question kai to question_id
        public static void SearchQuiz_Question(int quiz_id)
        {
            ClearLists();
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@quiz_question, conn))
                    {
                        conn.Open();
                        searchCommand.Parameters.AddWithValue("@p1", quiz_id);
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            while (searchReader.Read())
                            {
                                questionIDList.Add(searchReader.GetInt32(0));
                                questionsList.Add(searchReader.GetString(1));
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
                                    report = new Report(searchReader.GetInt32(0),searchReader.GetInt32(1),searchReader.GetInt32(2),searchReader.GetInt32(3),searchReader.GetString(4),searchReader.GetBoolean(5));
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
        public static void DeleteOneReport()
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteOne, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",true);
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
        //update se ola ta delete checkboxes se true-false
        public static void UpdateAllDeleteCheckboxes(bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@updateAlldel, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",check);
                        //dataAdapter
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
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //update ena delete checkbox me true-false
        public static void UpdateOneDeleteCheckbox(int report_id,bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@updateOneDel, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1", check);
                        updateCommand.Parameters.AddWithValue("@p2", report_id);

                        //dataAdapter
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
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
