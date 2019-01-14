using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.QuestionHandler
{
    static class QuestionController
    {
        private static OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString);
        private static OleDbCommand command;
        private static OleDbDataReader reader;
        private static OleDbDataAdapter adapter;

        private static string searchQuestionID = "Select Question.Question_id,Question.Question,Question.Cr_date,Question.Subject_id,[User].[Username],Quiz.Rating From ((Question inner join [User] on Question.By_user = [User].User_id) inner join Quiz on Question.Quiz_id = Quiz.Quiz_id) Where Question.Question_id = ?;";
        private static string question_answer = "Select Answer.Answer_id,Answer.Answer,Answer.Correct From Question inner join Answer on Question.Question_id = Answer.Question_id Where Question.Question_id = ?;";
        private static string deleteQuestion = "Delete From Question Where Question_id = ?;";
        private static string deleteAnswers = "Delete From Answer Where Question_id = ?;";
        private static string updateQuestion = "Update Question Set Question = ? Where Question_id = ?;";
        private static string updateAnswer = "Update Answer Set Answer = ?, Correct = ? Where Answer_id = ?;";

        public static int question_id { get; set; }
        public static string question { get; set; }
        public static string cr_date { get; set; }
        public static int subject_id { get; set; }
        public static string username { get; set; }
        public static int rating { get; set; }

        private static List<int> answerIDList = new List<int>();
        private static List<string> answers = new List<string>();
        private static List<bool> correctList = new List<bool>();
        public static List<int> GetAnswerIDs()
        {
            return answerIDList;
        }
        public static List<string> GetAnswers()
        {
            return answers;
        }
        public static List<bool> GetCorrectList()
        {
            return correctList;
        }
        private static void ClearLists()
        {
            answerIDList.Clear();
            answers.Clear();
            correctList.Clear();
        }


        //psaxe gia ton question
        public static bool SearchQuestionID(int questionID)
        {
            try
            {
                using (command = new OleDbCommand(@searchQuestionID,conn))
                {
                    bool check = false;
                    conn.Open();

                    command.Parameters.AddWithValue("@p1",questionID);
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            check = true;
                            while (reader.Read())
                            {
                                question_id = reader.GetInt32(0);
                                question = reader.GetString(1);
                                cr_date = reader.GetDateTime(2).ToString();
                                subject_id = reader.GetInt32(3);
                                username = reader.GetString(4);
                                rating = reader.GetInt32(5);
                            }
                        }
                        else
                        {
                            question_id = -1;
                            question = "Not found";
                            cr_date = "--/--/----";
                            subject_id = -1;
                            username = "Not found";
                            rating = 0;
                        }
                        reader.Close();
                    }
                    conn.Close();
                    return check;
                }
            } catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }
        //psaxe gia answers tou question
        public static void SearchAnswers()
        {
            ClearLists();   //kane clear prin apo kathe search
            try
            {
                using (command = new OleDbCommand(@question_answer, conn))
                {
                    conn.Open();

                    command.Parameters.AddWithValue("@p1", question_id);
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                answerIDList.Add(reader.GetInt32(0));
                                answers.Add(reader.GetString(1));
                                correctList.Add(reader.GetBoolean(2));
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        //kane delete ena question
        public static void DeleteQuestion(int questionID)
        {
            try
            {
                conn.Open();
                using (command = new OleDbCommand(@deleteQuestion, conn))
                {
                    command.Parameters.AddWithValue("@p1", questionID);
                    using (adapter = new OleDbDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                using (command = new OleDbCommand(@deleteAnswers, conn))
                { 
                    command.Parameters.AddWithValue("@p1", questionID);
                    using (adapter = new OleDbDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Question deleted successfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        //kane update ena question
        public static void UpdateQuestion(int questionID,string ques)
        {
            try
            {
                conn.Open();
                using (command = new OleDbCommand(@updateQuestion, conn))
                {
                    command.Parameters.AddWithValue("@p1", ques);
                    command.Parameters.AddWithValue("@p2",questionID);
                    using (adapter = new OleDbDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Question updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        //kane update ena answer
        public static void UpdateAnswer(int answerID,string answr,bool corr)
        {
            try
            {
                conn.Open();
                using (command = new OleDbCommand(@updateAnswer, conn))
                {
                    command.Parameters.AddWithValue("@p1", answr);
                    command.Parameters.AddWithValue("@p2", corr);
                    command.Parameters.AddWithValue("@p3",answerID);
                    using (adapter = new OleDbDataAdapter())
                    {
                        adapter.UpdateCommand = command;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Answer updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
