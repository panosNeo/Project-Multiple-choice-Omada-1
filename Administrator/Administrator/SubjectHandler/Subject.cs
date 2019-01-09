using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.SubjectHandler
{
    class Subject
    {
        private int subject_id;
        private int root_id;
        private string name;

        //subject list me ta uparxonta subjects
        private static List<Subject> subjectList = new List<Subject>();

        public Subject()
        {
            subject_id = 0;
            root_id = 0;
            name = "Nothing";
        }
        
        public Subject(int subject_id,int root_id,string name)
        {
            this.subject_id = subject_id;
            this.root_id = root_id;
            this.name = name;
        }

        public void SetSubjectID(int subject_id) {
            this.subject_id = subject_id;
        }
        public int GetSubjectID()
        {
            return subject_id;
        }

        public void SetRootID(int root_id)
        {
            this.root_id = root_id;
        }
        public int GetRootID()
        {
            return root_id;
        }

        public virtual void SetSubjectName(string name)
        {
            this.name = name;
        }
        public virtual string GetSubjectName()
        {
            return name;
        }
        
        public string PrintSubjectData()
        {
            return subject_id + " " + root_id + " " + name;
        }


        //Methods gia to list
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

        //adeiase th lista
        public static void ClearList()
        {
            subjectList.Clear();
        }

        //sort th lista 
        public static void SortList()
        {
            subjectList.Sort((x,y) => x.GetRootID().CompareTo(y.GetRootID()));
        }
    }
}
