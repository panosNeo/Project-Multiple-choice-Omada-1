using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Administrator.LoginHandler;

namespace Administrator
{
    class DBConnection
    {
        private static OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString);
        private static OleDbCommand searchCommand;
        private static OleDbDataReader searchReader;
        public static LoginHandler.User SearchAccountData(string username)
        {
            LoginHandler.User user = new LoginHandler.User();
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"SELECT * FROM [User] WHERE Username=?", conn);
                searchCommand.Parameters.AddWithValue("@p1", username);
                searchReader = searchCommand.ExecuteReader();
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
                        countRow++;
                    }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
            }
            return new LoginHandler.User();
        }
        public static LoginHandler.User SearchBlockData(User username)
        {
            LoginHandler.User user = username;
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"SELECT * FROM [Blocked] WHERE User_id=?", conn);
                searchCommand.Parameters.AddWithValue("@p1", user.userID);
                searchReader = searchCommand.ExecuteReader();
                int countRow = 0;
                while (searchReader.Read())
                {
                    //set profile data
                    user.blockID = searchReader.GetInt32(0);
                    user.reason = searchReader.GetString(2);
                    user.blockedDays = searchReader.GetInt32(3);
                    user.isBlocked = searchReader.GetBoolean(4);
                    
                    countRow++;
                }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
            }
            return new LoginHandler.User();
        }
        public static bool UpdateUserData(User username)
        {
            LoginHandler.User user = username;
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"Update [User] Set Email = ?,First_name = ?,Last_name = ? Where User_id = ?;", conn);
                //searchCommand.Parameters.AddWithValue("@p1", user.username);
                searchCommand.Parameters.AddWithValue("@p1", user.email);
                searchCommand.Parameters.AddWithValue("@p2", user.name);
                searchCommand.Parameters.AddWithValue("@p3", user.surname);
                searchCommand.Parameters.AddWithValue("@p4", user.userID);
                searchReader = searchCommand.ExecuteReader();
                int countRow = 0;
                while (searchReader.Read())
                {
                    
                    countRow++;
                }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }
        public static bool DeleteUser(int id)
        {
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"Delete from [User] Where User_id = ?;", conn);
                //searchCommand.Parameters.AddWithValue("@p1", user.username);
                searchCommand.Parameters.AddWithValue("@p1", id);
                
                searchReader = searchCommand.ExecuteReader();
                int countRow = 0;
                while (searchReader.Read())
                {
                    countRow++;
                }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }
        public static bool UpdateBlock(int id, int days, string reason, bool blocked)
        {
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"Update [Blocked] set Reason=?, Days=?,Blocked=? Where Block_id = ?;", conn);
                //searchCommand.Parameters.AddWithValue("@p1", user.username);
                searchCommand.Parameters.AddWithValue("@p1", reason);
                searchCommand.Parameters.AddWithValue("@p2", days);
                searchCommand.Parameters.AddWithValue("@p3", blocked);
                searchCommand.Parameters.AddWithValue("@p4", id);

                searchReader = searchCommand.ExecuteReader();
                int countRow = 0;
                while (searchReader.Read())
                {
                    countRow++;
                }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }
        public static bool InsertBlock(int id, string reason, int days, bool blocked)
        {
            try
            {
                conn.Open();
                //parametroi sto query
                searchCommand = new OleDbCommand(@"Insert into [Blocked](User_id, Reason, Days, Blocked) values(?,?,?,?)", conn);
                //searchCommand.Parameters.AddWithValue("@p1", user.username);
                searchCommand.Parameters.AddWithValue("@p1", id);
                searchCommand.Parameters.AddWithValue("@p2", reason);
                searchCommand.Parameters.AddWithValue("@p3", days);
                searchCommand.Parameters.AddWithValue("@p3", blocked);

                searchReader = searchCommand.ExecuteReader();
                int countRow = 0;
                while (searchReader.Read())
                {
                    countRow++;
                }
                Console.WriteLine("Records found: " + countRow);
                searchReader.Close();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }
    }
}
