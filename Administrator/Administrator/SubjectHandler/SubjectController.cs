using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.SubjectHandler
{
    static class SubjectController
    {
        //queries
        private static string existingSubjects = "Select * From Subject";
        private static string countQuizzes = "Select Count(*) From Quiz inner join Subject on Quiz.Subject_id = Subject.Subject_id Where Subject.Root_id = ?";
        private static string addNewSubject = "Insert Into Subject(Subject_id,Root_id,S_name) Values(?,?,?);";
        private static string deleteSubject = "Delete From Subject Where Subject_id = ? AND Root_id = ?;";
        private static string updateSubject = "Update Subject Set Root_id = ?, S_name = ? Where Subject_id = ?;";

        private static string searchQuizzes = "Select Quiz.Quiz_id,Quiz.By_user,Quiz.Cr_date,Quiz.Title,Quiz.Subject_id,Subject.S_name,Subject.Root_id From Subject inner join Quiz on Subject.Subject_id = Quiz.Subject_id Where Subject.Subject_id = ?;";
        private static string totalQuestions = "Select Count(*) From Quiz inner join Question on Quiz.Quiz_id = Question.Quiz_id Where Quiz.Quiz_id = ?;";

        private static string addNewQuiz = "Insert Into Quiz(Quiz_id,By_user,Cr_date,Title,Subject_id) Values(?,?,?,?,?);";
        private static string deleteQuiz = "Delete from Quiz Where Quiz_id = ?;";
        private static string updateQuiz = "Update Quiz Set By_user = ?, Cr_date = ?, Title = ? , Subject_id = ? Where Quiz_d = ?;";

        //objects
        private static Subject subject;
        private static QuizHandler.Quiz quiz;

        //Methods gia to Existing Subject Groupbox
        //
        //kane search gia ola ta subjects pou uparxoun
        public static void SearchForExistingSubjects()
        {
            Subject.ClearList(); //kane clear th lista prin apo kathe search
            try {
                //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@existingSubjects, conn))
                    {
                        conn.Open();

                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            if (exSubReader.HasRows)
                                //gia kathe row pou vrethike
                                while (exSubReader.Read())
                                {
                                    //ftiaxe subject object me to data tou subject
                                    subject = new Subject(exSubReader.GetInt32(0), exSubReader.GetInt32(1), exSubReader.GetString(2));
                                    //kanto add sth lista me ta subjects
                                    Subject.Add(subject);
                                }
                            else
                            {
                                subject = new Subject();
                                Subject.Add(subject);
                            }
                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            } catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane search kai count ola ta quiz pou uparxoun gia kathe subject 3exwrista
        public static int QuizzesCounter(int rootID)
        {
            try
            {   //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@countQuizzes, conn))
                    {
                        conn.Open();
                        //parametroi gia to query
                        exSubCommand.Parameters.AddWithValue("@p1", rootID);
                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            int counter = -2;
                            if (exSubReader.HasRows)
                            {
                                while (exSubReader.Read())
                                    counter = exSubReader.GetInt32(0);
                                return counter;
                            }

                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        //Methods gia to Data Settings Groupbox
        //
        //kane add ena neo Subject
        public static void AddNewSubject(int subjectID, int rootID, string name)
        {
            try
            {   //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@addNewSubject, conn))
                    {
                        conn.Open();


                        exSubCommand.Parameters.AddWithValue("@p1",subjectID);
                        exSubCommand.Parameters.AddWithValue("@p1",rootID);
                        exSubCommand.Parameters.AddWithValue("@p2",name);

                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            MessageBox.Show("Subject is added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane delete ena subject me vash to subject id kai to root id
        public static void DeleteSubject(int subjectID, int rootID)
        {
            try
            {
                //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@deleteSubject, conn))
                    {
                        conn.Open();

                        exSubCommand.Parameters.AddWithValue("@p1", subjectID);
                        exSubCommand.Parameters.AddWithValue("@p2", rootID);

                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            MessageBox.Show("Subject is deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane update ena subject
        public static void UpdateSubject(int subjectID,int rootID,string name)
        {
            try
            {   //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@updateSubject, conn))
                    {
                        conn.Open();

                        //exSubCommand.Parameters.AddWithValue("@p1",subjectID);
                        exSubCommand.Parameters.AddWithValue("@p1", rootID);
                        exSubCommand.Parameters.AddWithValue("@p2", name);
                        exSubCommand.Parameters.AddWithValue("@p3", subjectID);

                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            MessageBox.Show("Subject is updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Methods gia ta Quizzes
        //
        //psaxe gia ola ta quizzes pou uparxoun sto antistoixo subject id
        public static void SearchForQuizzes(int subject_id)
        {
            QuizHandler.Quiz.ClearList(); //kane clear th lista prin apo kathe search
            try
            {//connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@searchQuizzes, conn))
                    {
                        conn.Open();

                        exSubCommand.Parameters.AddWithValue("@p1",subject_id);
                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            if (exSubReader.HasRows)
                                //gia kathe row pou vrethike
                                while (exSubReader.Read())
                                {
                                    //ftiaxe quiz object me to data tou
                                    quiz = new QuizHandler.Quiz(exSubReader.GetInt32(0),exSubReader.GetInt32(1),exSubReader.GetString(3),exSubReader.GetDateTime(2).ToString());
                                    quiz.SetSubjectID(exSubReader.GetInt32(4));
                                    quiz.SetSubjectName(exSubReader.GetString(5));
                                    quiz.SetRootID(exSubReader.GetInt32(6));
                                    //kanto add sth lista me ta quiz
                                    QuizHandler.Quiz.Add(quiz);
                                }
                            else
                            {
                                quiz = new QuizHandler.Quiz();
                                QuizHandler.Quiz.Add(quiz);
                            }
                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metra poses erwthseis exei to antoistixo quiz
        public static int CountQuestions(int quiz_id)
        {
            try
            {   //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@totalQuestions, conn))
                    {
                        conn.Open();
                        //parametroi gia to query
                        exSubCommand.Parameters.AddWithValue("@p1", quiz_id);
                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            int counter = -2;
                            if (exSubReader.HasRows)
                            {
                                while (exSubReader.Read())
                                    counter = exSubReader.GetInt32(0);
                                return counter;
                            }

                            exSubReader.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {//exceptions ths vashs
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {//upoloipa exceptions
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        //kane add ena kainourio quiz
        public static void AddNewQuiz(int quiz_id,int user_id,string cr_date,string title,int subject_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand insertCommand = new OleDbCommand(@addNewQuiz, conn))
                    {
                        conn.Open();

                        insertCommand.Parameters.AddWithValue("@p1", quiz_id);
                        insertCommand.Parameters.AddWithValue("@p2", user_id);
                        insertCommand.Parameters.AddWithValue("@p3", cr_date);
                        insertCommand.Parameters.AddWithValue("@p4", title);
                        insertCommand.Parameters.AddWithValue("@p5", subject_id);
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = insertCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            MessageBox.Show("Quiz added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //kane delete ena quiz me vash to quiz id
        public static void DeleteQuiz(int quiz_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand insertCommand = new OleDbCommand(@deleteQuiz, conn))
                    {
                        conn.Open();

                        insertCommand.Parameters.AddWithValue("@p1", quiz_id);
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = insertCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            MessageBox.Show("Quiz deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //kane update ena quiz me vash to quiz id
        public static void UpdateQuiz(int quiz_id, int user_id, string cr_date, string title, int subject_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand insertCommand = new OleDbCommand(@updateQuiz, conn))
                    {
                        conn.Open();
                        insertCommand.Parameters.AddWithValue("@p1", user_id);
                        insertCommand.Parameters.AddWithValue("@p2", cr_date);
                        insertCommand.Parameters.AddWithValue("@p3", title);
                        insertCommand.Parameters.AddWithValue("@p4", subject_id);
                        insertCommand.Parameters.AddWithValue("@p5", quiz_id);
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = insertCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            MessageBox.Show("Quiz updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
