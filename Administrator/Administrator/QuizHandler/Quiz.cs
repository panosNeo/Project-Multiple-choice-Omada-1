using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.QuizHandler
{
    class Quiz : SubjectHandler.Subject
    {
        private int quiz_id;
        private int user_id;
        //private int subject_id;
        private string name;
        private string cr_date;


        public Quiz(int quiz_id, int user_id,string name,string cr_date) : base(0,0,"")
        {
            this.quiz_id = quiz_id;
            this.user_id = user_id;
            this.name = name;
            this.cr_date = cr_date;
        }

        public void SetQuizID(int quiz_id)
        {
            this.quiz_id = quiz_id;
        }
        public int GetQuizID()
        {
            return quiz_id;
        }

        public void SetUserID(int user_id)
        {
            this.user_id = user_id;
        }
        public int GetUserID()
        {
            return user_id;
        }

        public override void SetName(string name)
        {
            this.name = name;
        }
        public override string GetName()
        {
            return name;
        }

        public virtual void SetCrDate(string cr_date)
        {
            this.cr_date = cr_date;
        }
        public virtual string GetCrDate()
        {
            return cr_date;
        }

        public string PrintQuizData()
        {
            return quiz_id + " " + user_id + " " + base.GetSubjectID() + " " + this.name + " " + cr_date ;
        }
    }
}
