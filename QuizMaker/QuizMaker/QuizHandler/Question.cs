using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.QuizHandler
{
    public class Question
    {
        private int q_id;
        private String question;
        private List<Answer> answers;

        private int by_user_id;
        private int rating;
        private int subject_id;
        private DateTime creationDate;
        

        //CONSTRUCTOR, create Question object//

        public Question()
        {
            this.answers = new List<Answer>();
            q_id = -1;
        }

        public Question(string question, int user, int subject, DateTime date)
        {
            this.question = question;
            this.by_user_id = user;
            this.subject_id = subject;
            this.creationDate = date;
            this.rating = 0;
            this.answers = new List<Answer>();
            q_id = -1;
        }

        //SETTERS, change variables//
        public void SetQuestion(string question)
        {
            this.question = question;
        }
        public void SetUser(int user)
        {
            this.by_user_id = user;
        }
        public void SetSubject(int subject)
        {
            this.subject_id = subject;
        }
        public void SetQuestion_id(int q_id)
        {
            this.q_id = q_id;
        }

        //GETTERS//
        public string GetQuestion()
        {
            return this.question;
        }
        public List<Answer> GetAnswers()
        {
            return answers;
        }
        public int GetUser_id()
        {
            return by_user_id;
        }
        public int GetRating()
        {
            return rating;
        }
        public int GetSubject()
        {
            return subject_id;
        }
        public DateTime GetCrDate()
        {
            return creationDate;
        }
        public int GetQuestion_id()
        {
            return q_id;
        }

        public void AddAnswer(Answer answer)
        {
            answers.Add(answer);
        }

        public bool RemoveAnswer(int position)
        {
            if (answers.Count <= position)
                return false;
            else
            {
                answers.RemoveAt(position);
                return true;
            }
        }

        public void HandleRating()
        {
            //tha doume//
        }
    }
}
