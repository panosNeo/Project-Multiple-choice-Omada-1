using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;

namespace Administrator.LoginHandler
{
    static class UserDataController
    {
        private static OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString);
        private static OleDbCommand command;
        private static OleDbDataReader reader;

        public static int feedbacks { set; get; }
        public static int reports { set; get; }

        //update to data se periptwsh allaghs dedomenwn
        public static void UpdateUserData(string name, string lastname, string email, string username, string password)
        {
            try
            {
                //dhmiourgia command kai command text
                using (command = new OleDbCommand(@"Update [User] Set [Username] = ?,[Password] = ?,Email = ?,First_name = ?,Last_name = ? Where User_id = ?;", conn))
                {
                    conn.Open();

                    //parametroi sto query
                    command.Parameters.AddWithValue("@p1", username);
                    command.Parameters.AddWithValue("@p2", password);
                    command.Parameters.AddWithValue("@p3", email);
                    command.Parameters.AddWithValue("@p4", name);
                    command.Parameters.AddWithValue("@p5", lastname);
                    command.Parameters.AddWithValue("@p6", Profile.GetUserID());
                    //data reader
                    using (reader = command.ExecuteReader())
                    {
                        Profile.SetUsername(username);
                        Profile.SetPassword(password);
                        Profile.SetEmail(email);
                        Profile.SetName(name);
                        Profile.SetLastname(lastname);

                        MessageBox.Show("Successful update.");
                        reader.Close();
                    }
                 conn.Close();
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

        public static void CheckForNotes()
        {
            try
            {
                conn.Open();
                //dhmiourgia command kai command text
                using (command = new OleDbCommand(@"Select Count(*) From Feedback;", conn))
                {
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while(reader.Read())
                                feedbacks = reader.GetInt32(0);
                        }
                        else
                        {
                            feedbacks = 0;
                        }
                        reader.Close();
                    }
                }
                //dhmiourgia command kai command text
                using (command = new OleDbCommand(@"Select Count(*) From Report;", conn))
                {
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                                reports = reader.GetInt32(0);
                        }
                        else
                        {
                            reports = 0;
                        }
                        reader.Close();
                    }
                }
                conn.Close();
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
