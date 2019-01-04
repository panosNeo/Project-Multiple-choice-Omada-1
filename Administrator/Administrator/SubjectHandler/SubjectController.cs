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
        private static string countQuizzes = "Select Count(*) From Quiz Where Quiz_id = ?";

        //subject list me ta uparxonta subjects
        private static List<Subject> subjectList = new List<Subject>();
        private static Subject subject;

        //kane search gia ola ta subjects pou uparxoun
        public static void SearchForExistingSubjects()
        {
            subjectList.Clear(); //kane clear th lista prin apo kathe search
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
                                    Add(subject);
                                }
                            else
                            {
                                subject = new Subject();
                                Add(subject);
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
        public static int QuizzesCounter(int subjectID)
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
                        exSubCommand.Parameters.AddWithValue("@p1",subjectID);
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

        
        //add ena subject
        public static void Add(Subject subject)
        {
            try
            {
                //checkare gia diplotupo
                bool checkForDuplicate = subjectList.Contains(subject);

                //an uparxei hdh tote petaxe mhnuma
                //alliws kane add
                if (checkForDuplicate)
                    MessageBox.Show("The subject already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    subjectList.Add(subject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete ena subject
        public static void Delete(Subject subject)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = subjectList.Contains(subject);

                if (checkIfexist)
                    subjectList.Remove(subject);
                else
                    MessageBox.Show("This Subject does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //return th lista me ta subjects
        public static List<Subject> GetList()
        {
            return subjectList;
        }

    }
}
