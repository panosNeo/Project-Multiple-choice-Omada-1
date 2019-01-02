using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;

namespace Administrator.LoginHandler
{
    class UserDataController
    {
        //profile object me to data pou ekane login
        //private static Profile profile = LoginHandler.GetProfile();

        public UserDataController()
        {
        }

        //update to data se periptwsh allaghs dedomenwn
        public static void UpdateUserData(string name, string lastname, string email, string username, string password)
        {
            try
            {
                //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@"Update [User] Set [Username] = ?,[Password] = ?,Email = ?,First_name = ?,Last_name = ? Where User_id = ?;", conn))
                    {
                        conn.Open();

                        //parametroi sto query
                        updateCommand.Parameters.AddWithValue("@p1", username);
                        updateCommand.Parameters.AddWithValue("@p2", password);
                        updateCommand.Parameters.AddWithValue("@p3", email);
                        updateCommand.Parameters.AddWithValue("@p4", name);
                        updateCommand.Parameters.AddWithValue("@p5", lastname);
                        updateCommand.Parameters.AddWithValue("@p6", Profile.GetUserID());

                        //data reader
                        using (OleDbDataReader updateReader = updateCommand.ExecuteReader())
                        {
                            Profile.SetUsername(username);
                            Profile.SetPassword(password);
                            Profile.SetEmail(email);
                            Profile.SetName(name);
                            Profile.SetLastname(lastname);

                            MessageBox.Show("Successful update.");
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

        public void CheckForNotes()
        {
            //Under construction
            //tha elegxei gia notes
        }

    }
}
