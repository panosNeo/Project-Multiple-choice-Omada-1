using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.FeedbackHandler
{
    static class FeedbackController
    {
        private static string searchForFeedbacks = "Select Feedback_id,User_id,Feedback,Admin_aproval From Feedback;";
        private static string setDeleteBool = "Delete From Feedback Where Feedback_id = ?;";
        private static string setAllAdminAproval = "Update Feedback Set Admin_aproval = ?;";
        private static string setAdminAproval = "Update Feedback Set Admin_aproval = ? Where Feedback_id = ?;";
        private static string deleteFeedbacks = "Delete From Feedback;";

        private static bool hasFeedbacks = false;   //an uparxoun feedbacks tote true
        private static Feedback feedback;
        //search gia feedbacks
        public static void SearchFeedbacks()
        {
            Feedback.ClearList();   //kane clear to list prin apo kathe search
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand searchCommand = new OleDbCommand(@searchForFeedbacks, conn))
                    {
                        conn.Open();
                        //datareader
                        using (OleDbDataReader searchReader = searchCommand.ExecuteReader())
                        {
                            if (searchReader.HasRows)
                            {
                                hasFeedbacks = true;
                                while (searchReader.Read())
                                {   //ftiaxe to feeback
                                    feedback = new Feedback(searchReader.GetInt32(0),searchReader.GetInt32(1),searchReader.GetString(2),searchReader.GetBoolean(3));
                                    //kai kane to add sth lista
                                    Feedback.Add(feedback);
                                }
                            }
                            else
                                hasFeedbacks = false;

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
        //an yparxei feedback epestrepse true
        public static bool GetHasFeedbacks()
        {
            return hasFeedbacks;
        }
        //kane delete ena feedback
        public static void DeleteCheckbox(int feedback_id)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@setDeleteBool, conn))
                    {
                        conn.Open();
                        
                        updateCommand.Parameters.AddWithValue("@p1",feedback_id);

                        //datareader
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query

                            //kane delete to item apo th lista me ta feedbacks
                            foreach (var item in Feedback.GetList())
                            {
                                if (item.GetFeedbackID() == feedback_id)
                                {
                                    Feedback.Delete(item);
                                    break;
                                }
                            }
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
        //kane update ena admin aproval
        public static void UpdateRateCheckbox(int feedback_id, bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@setAdminAproval, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1", check);
                        updateCommand.Parameters.AddWithValue("@p2", feedback_id);

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
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane update se ola ta admin_aproval
        public static void UpdateAllCheckboxes(bool check)
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@setAllAdminAproval, conn))
                    {
                        conn.Open();

                        updateCommand.Parameters.AddWithValue("@p1",check);
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
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //kane diagrafh se ola ta feedbacks
        public static void DeleteFeedbacks()
        {
            try
            {   //connection string
                using (OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabaseConnectionString))
                {   //dhmiourgia command kai command text
                    using (OleDbCommand updateCommand = new OleDbCommand(@deleteFeedbacks, conn))
                    {
                        conn.Open();
                        //datareader
                        using (OleDbDataAdapter updateAdapter = new OleDbDataAdapter())
                        {
                            updateAdapter.UpdateCommand = updateCommand;    //update to query ston adapter
                            updateAdapter.UpdateCommand.ExecuteNonQuery();  //ektelese to query 
                            Feedback.ClearList();   //adeiase th lista
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
