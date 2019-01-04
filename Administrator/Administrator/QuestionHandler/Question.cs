using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.QuestionHandler
{
    class Question : QuizHandler.Quiz
    {
        private int question_id;
        //private int user_id;
        private string question;
        private int rating;
        private string cr_date;

        //lista me ola ta question ana quiz
        private static List<Question> questionList = new List<Question>();

        public Question(int question_id,string question,int rating,string cr_date) 
            : base(0,0,"Nothing","1/1/2019")
        {
            this.question_id = question_id;
            this.question = question;
            this.rating = rating;
            this.cr_date = cr_date;
        }

        public void SetQuestionID(int question_id)
        {
            this.question_id = question_id;
        }
        public int GetQuestionID()
        {
            return question_id;
        }
        
        public void SetQuestion(string question)
        {
            this.question = question;
        }
        public string GetQuestion()
        {
            return question;
        }
        
        public void SetRating(int rating)
        {
            this.rating = rating;
        }
        public int GetRating()
        {
            return rating;
        }

        public override void SetCrDate(string cr_date)
        {
            this.cr_date = cr_date;
        }
        public override string GetCrDate()
        {
            return cr_date;
        }

        public string PrintQuestionData()
        {
            return question_id + " " + base.GetUserID() + " " + base.GetSubjectID() + " " + question + " " + rating + " " + cr_date;
        }

        //Methods gia to list
        //add ena subject
        public static void Add(Question question)
        {
            try
            {
                //checkare gia diplotupo
                bool checkForDuplicate = questionList.Contains(question);

                //an uparxei hdh tote petaxe mhnuma
                //alliws kane add
                if (checkForDuplicate)
                    MessageBox.Show("The subject already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    questionList.Add(question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete ena subject
        public static void Delete(Question question)
        {
            try
            {
                //checkare gia diplotupo
                bool checkIfexist = questionList.Contains(question);

                if (checkIfexist)
                    questionList.Remove(question);
                else
                    MessageBox.Show("This Subject does not exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //return th lista me ta subjects
        public new static List<Question> GetList()
        {
            return questionList;
        }

        //adeiase th lista
        public new static void ClearList()
        {
            questionList.Clear();
        }

    }
}
