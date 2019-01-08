using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.ReportHandler
{
    static class ReportController
    {
        private static string searchForReports = "Select Report_id,User_id,Quiz_id,Question_id,Report,Delete From Report;";
        private static string deleteOne = "Delete From Report Where Report_id = ?;";
        private static string deleteAll = "Delete From Report;";
        private static string updateAlldel = "Update Report Set Delete = ?;";
        private static string updateOneDel = "Update Report Set Delete = ? Where Report_id = ?;";

        private static bool hasReports = false; //an yparxoun reports tote true
        private static Report report;
        //psaxe gia reports
        public static void SearchForReports()
        {
            Report.ClearList(); //kane clear th lista prin apo kathe search
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@searchForReports, conn))
                    {
                        conn.Open();
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            if (searchReader.HasRows)
                            {
                                hasReports = true;
                                while (searchReader.Read())
                                {   //ftiaxe to report
                                    report = new Report(searchReader.GetInt32(0),searchReader.GetInt32(1),searchReader.GetInt32(2),searchReader.GetInt32(3),searchReader.GetString(4),searchReader.GetBoolean(5));
                                    //kai kane to add sth lista
                                    Report.Add(report);
                                }
                            }
                            else
                                hasReports = false;

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
        //an uparxei report epestrepse true
        public static bool GetHasReports()
        {
            return hasReports;
        }
        //kane delete ola osa einai true
        public static void DeleteOneReport()
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteOne, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",true);
                        //datareader
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query
                        }
                        conn.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane delete ola ta reports
        public static void DeleteAllReports()
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteAll, conn))
                    {
                        conn.Open();
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            Report.ClearList();   //adeiase th lista
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
        //update se ola ta delete checkboxes se true-false
        public static void UpdateAllDeleteCheckboxes(bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@updateAlldel, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",check);
                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
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
        //update ena delete checkbox me true-false
        public static void UpdateOneDeleteCheckbox(int report_id,bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@updateOneDel, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1", check);
                        updateCommand.Parameters.AddWithValue("@p2", report_id);

                        //dataAdapter
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
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
