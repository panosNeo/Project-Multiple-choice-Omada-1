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

        public virtual void SetName(string name)
        {
            this.name = name;
        }
        public virtual string GetName()
        {
            return name;
        }
        
        public string PrintSubjectData()
        {
            return subject_id + " " + root_id + " " + name;
        }
    }
}
