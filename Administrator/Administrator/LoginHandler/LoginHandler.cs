using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;

namespace Administrator.LoginHandler
{
    class LoginHandler
    {
        private string username;
        private string password;
        
        private bool successLogin = false;

        public LoginHandler(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        //kane search gia to account
        public void SearchAccount()
        {
            try
            {
                //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@"SELECT * FROM [User] WHERE [Username]=? AND [Password]=? AND Role=?", conn))
                    {
                        conn.Open();

                        //parametroi sto query
                        searchCommand.Parameters.AddWithValue("@p1", username);
                        searchCommand.Parameters.AddWithValue("@p2", password);
                        searchCommand.Parameters.AddWithValue("@p3", "Admin");

                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            int countRow = 0;
                            while (searchReader.Read())
                            {
                                //set profile data
                                Profile.SetUserID(searchReader.GetInt32(0));
                                Profile.SetUsername(searchReader.GetString(1));
                                Profile.SetPassword(searchReader.GetString(2));
                                Profile.SetEmail(searchReader.GetString(4));
                                Profile.SetName(searchReader.GetString(5));
                                Profile.SetLastname(searchReader.GetString(6));

                                countRow++;
                            }

                            if (countRow > 0)
                            {
                                //true gia epituxei tautopoihsh stoixeiwn
                                successLogin = true;
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
        
        //prospelash ths boolean success login
        public bool getSuccessLogin()
        {
            return successLogin;
        }

    }
}
