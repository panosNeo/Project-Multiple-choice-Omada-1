using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Administrator
{
    class DBConnection
    {
        public static LoginHandler.User SearchAccountData(string username)
        {
            LoginHandler.User user = new LoginHandler.User();
            try
            {
                //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {
                    //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@"SELECT * FROM [User] INNER JOIN Blocked on User.User_id = Blocked.User_id WHERE [Username]=?", conn))
                    {
                        conn.Open();

                        //parametroi sto query
                        searchCommand.Parameters.AddWithValue("@p1", username);
                        
                        

                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            int countRow = 0;
                            
                            while (searchReader.Read())
                            {
                                //set profile data
                                user.userID = searchReader.GetInt32(0);
                                user.username = searchReader.GetString(1);
                                user.role = searchReader.GetString(3);
                                user.email = searchReader.GetString(4);
                                user.name = searchReader.GetString(5);
                                user.surname = searchReader.GetString(6);
                                if (searchReader.GetString(7) != null)
                                {
                                    user.reason = searchReader.GetString(9);
                                    user.blockedDays = Convert.ToInt32(searchReader.GetInt32(10));
                                    user.isBlocked = searchReader.GetBoolean(11);
                                }
                                

                                countRow++;
                            }

                            

                            searchReader.Close();
                            
                        }

                        conn.Close();
                        
                    }
                }
                return user;
            }
            catch (OleDbException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return new LoginHandler.User();
        }

        
    }
}
