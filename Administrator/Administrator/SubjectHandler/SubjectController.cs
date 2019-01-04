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

        
        private static Subject subject;
        
        //kane search gia ola ta subjects pou uparxoun
        public static void SearchForExistingSubjects()
        {
            Subject.ClearList(); //kane clear th lista prin apo kathe search
            try {
                //connection
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //command gia na vrei ta subjects
                    using (OleDbCommand exSubCommand = new OleDbCommand(@existingSubjects,conn))
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
            }catch (OleDbException ex)
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
                    using (OleDbCommand exSubCommand = new OleDbCommand(countQuizzes, conn))
                    {
                        conn.Open();
                        //parametroi gia to query
                        exSubCommand.Parameters.AddWithValue("@p1",rootID);
                        //execute to command
                        using (OleDbDataReader exSubReader = exSubCommand.ExecuteReader())
                        {
                            int counter = -2;
                            if (exSubReader.HasRows)
                            {
                                while(exSubReader.Read())
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
    }
}
