using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.QuizHandler
{
    class Quiz : SubjectHandler.Subject
    {
        private int quiz_id;
        private int user_id;
        private string name;
        private string cr_date;

        //quiz list me ola ta quiz ana subject
        private static List<Quiz> quizList = new List<Quiz>();

        public Quiz()
        {
            quiz_id = 0;
            user_id = 0;
            name = "Nothing";
            cr_date = "1/1/2019";
        }

        public Quiz(int quiz_id, int user_id,string name,string cr_date) : base(0,0,"Nothing")
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


        //Methods gia to list
        //add ena subject
        public static void Add(Quiz quiz)
        {
            try
            {
                //checkare gia diplotupo
                bool checkForDuplicate = quizList.Contains(quiz);

                //an uparxei hdh tote petaxe mhnuma
                //alliws kane add
                if (checkForDuplicate)
                    MessageBox.Show("The subject already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    quizList.Add(quiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete ena subject
        public static void Delete(Quiz quiz)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = quizList.Contains(quiz);

                if (checkIfexist)
                    quizList.Remove(quiz);
                else
                    MessageBox.Show("This Subject does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //return th lista me ta subjects
        public new static List<Quiz> GetList()
        {
            return quizList;
        }

        //adeiase th lista
        public new static void ClearList()
        {
            quizList.Clear();
        }
    }
}
