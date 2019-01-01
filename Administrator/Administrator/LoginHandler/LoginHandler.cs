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
        private bool stayLog;

        private Profile profile;
        private bool successLogin = false;

        public LoginHandler(string username,string password,bool stayLog)
        {
            this.username = username;
            this.password = password;
            this.stayLog = stayLog;
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

                        searchCommand.Parameters.AddWithValue("@p1",username);
                        searchCommand.Parameters.AddWithValue("@p2",password);
                        searchCommand.Parameters.AddWithValue("@p3","Admin");

                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            int countRow = 0;
                            while (searchReader.Read())
                            {
                                countRow++;
                            }

                            if (countRow > 0)
                            {
                                //true gia epituxei tautopoihsh stoixeiwn
                                successLogin = true;   
                                //init to object me to data tou user pou kane login
                                //profile = new Profile(searchReader.GetInt32(0),searchReader.GetString(1), searchReader.GetString(2), searchReader.GetString(3), searchReader.GetString(4), searchReader.GetString(5), searchReader.GetString(6));
                                //UserData(profile);
                            }
                        }
                        
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.ToString(),"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void StayIn() {
            //checkarw gia na ton afhsw in
        }

        //prospelash ths boolean success login
        public bool getSuccessLogin()
        {
            return successLogin;
        }

        //gia na parw ta stoixeia tou user pou kane login
        public void UserData(Profile prof)
        {
            //under construction
        }
    }
}
