using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QuizMaker
{
    class ConnectDB
    {
        string con;
        string host = "sql300.epizy.com";
        string db = "epiz_23056713_quizMakerDB";
        string username = "epiz_23056713";
        string pass = "yA6L6IA6fb4EF";
        private MySqlConnection connection;

        public ConnectDB()
        {
            
            
            con = "SERVER=" + host + ";" + "DATABASE=" +
            db + ";" + "UID=" + username + ";" + "PASSWORD=" + pass + ";";

            connection = new MySqlConnection(con);
        }
        public void exec()
        {
            connection.Open();
            string query = "select * from user";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            Console.WriteLine(cmd.ExecuteNonQuery());
        }
    }
}
