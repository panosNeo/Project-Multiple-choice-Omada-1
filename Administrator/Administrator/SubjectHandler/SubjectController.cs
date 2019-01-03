using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;

namespace Administrator.SubjectHandler
{
    static class SubjectController
    {
        private static string query1 = " ";
        private static string query2 = " ";
        private static List<Subject> subjectList = new List<Subject>();






        //add ena subject
        public static void Add(Subject subject)
        {
            try
            {
                //checkare gia diplotupo
                bool checkForDuplicate = subjectList.Contains(subject);

                //an uparxei hdh tote petaxe mhnuma
                //alliws kane add
                if (checkForDuplicate)
                    MessageBox.Show("The subject already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    subjectList.Add(subject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete ena subject
        public static void Delete(Subject subject)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = subjectList.Contains(subject);

                if (checkIfexist)
                    subjectList.Remove(subject);
                else
                    MessageBox.Show("This Subject does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //return th lista me ta subjects
        public static List<Subject> GetList()
        {
            return subjectList;
        }

    }
}
