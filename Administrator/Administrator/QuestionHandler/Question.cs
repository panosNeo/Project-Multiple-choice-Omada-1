using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator.QuestionHandler
{
    class Question : QuizHandler.Quiz
    {
        private int question_id;
        private int user_id;
        private int subject_id;
        private string question;
        private int rating;
        private string cr_date;

        public Question(int question_id,int user_id,int subject_id,string question,int rating,string cr_date)
        {
            this.question_id = question_id;
            this.user_id = user_id;
            this.subject_id = subject_id;
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

        public void SetUserID(int user_id)
        {
            this.user_id = user_id;
        }
        public int GetUserID()
        {
            return user_id;
        }

        public virtual void SetSubjectID(int subject_id)
        {
            this.subject_id = subject_id;
        }
        public virtual int GetSubjectID()
        {
            return subject_id;
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

        public void SetCrDate(string cr_date)
        {
            this.cr_date = cr_date;
        }
        public string GetCrDate()
        {
            return cr_date;
        }

        public string PrintQuestionData()
        {
            return question_id + " " + user_id + " " + subject_id + " " + question + " " + rating + " " + cr_date;
        }

    }
}
