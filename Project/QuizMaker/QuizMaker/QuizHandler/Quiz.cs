using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.QuizHandler
{
    class Quiz
    {
        //private int quiz_id;
        private string quizTitle;
        private int subject_id;
        private int by_user_id;
        private DateTime creationDate;
        private List<Question> questions;

        public Quiz(string title, int subject, int user)
        {
            this.quizTitle = title;
            this.subject_id = subject;
            this.by_user_id = user;
            this.creationDate = DateTime.Now;
        }

        //SETTERS//
        public void SetQuizTitle(string title)
        {
            this.quizTitle = title;
        }
        public void SetSubject_id(int subject)
        {
            this.subject_id = subject;
        }

        //GETTERS//
        public string GetQuizTitle()
        {
            return quizTitle;
        }
        public int GetSubject_id()
        {
            return subject_id;
        }
        public int GetUser_id()
        {
            return by_user_id;
        }
        public DateTime GetCreationDate()
        {
            return creationDate;
        }
        public List<Question> getQuestions()
        {
            return questions;
        }

        //Handle question list//
        public void AddQuestion(string question, int subject)
        {
            questions.Add(new Question(question, by_user_id, subject_id, creationDate));
        }

        public bool RemoveQuestion(int position)
        {
            if (questions.Count <= position)
                return false;
            else
            {
                questions.RemoveAt(position);
                return true;
            }
        }
    }
}
