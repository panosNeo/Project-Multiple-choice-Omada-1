using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.FeedbackHandler
{
    class Feedback
    {
        private int feedback_id;
        private int user_id;
        private string feedback;
        private bool admin_aproval;

        private static List<Feedback> feedbackList = new List<Feedback>();

        public Feedback(int feedback_id, int user_id,string feedback,bool admin_aproval)
        {
            this.feedback_id = feedback_id;
            this.user_id = user_id;
            this.feedback = feedback;
            this.admin_aproval = admin_aproval;
        }

        public void SetFeedbackID(int feedback_id)
        {
            this.feedback_id = feedback_id;
        }
        public int GetFeedbackID()
        {
            return feedback_id;
        }

        public void SetUserID(int user_id)
        {
            this.user_id = user_id;
        }
        public int GetUserID()
        {
            return user_id;
        }

        public void SetFeedback(string feedback)
        {
            this.feedback = feedback;
        }
        public string GetFeedback()
        {
            return feedback;
        }

        public void SetAdminAproval(bool admin_aproval)
        {
            this.admin_aproval = admin_aproval;
        }
        public bool GetAdminAproval()
        {
            return admin_aproval;
        }

        public string PrintData()
        {
            return feedback_id + " " + user_id + " " + feedback + " " + admin_aproval;
        }

        //methods gia to feedback list
        //
        //add ena object 
        public static void Add(Feedback feedback)
        {
            try
            {
                //checkare gia diplotypo
                bool checkForDuplicate = feedbackList.Contains(feedback);

                if (checkForDuplicate)
                    MessageBox.Show("The already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    feedbackList.Add(feedback);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(Feedback feedback)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = feedbackList.Contains(feedback);

                if (checkIfexist)
                    feedbackList.Remove(feedback);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //katharise th lista
        public static void ClearList()
        {
            feedbackList.Clear();
        }

        //retun th lista
        public static List<Feedback> GetList()
        {
            return feedbackList;
        }
    }
}
