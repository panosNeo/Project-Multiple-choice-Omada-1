﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.QuizHandler
{
    public class Quiz
    {
        private int quiz_id;
        private string quizTitle;
        private int subject_id;
        private int by_user_id;
        private DateTime creationDate;
        private List<Question> questions;

        public Quiz()
        {
            this.questions = new List<Question>();
            this.quiz_id = -1;
        }

        public Quiz(string title, int subject, int user)
        {
            this.quizTitle = title;
            this.subject_id = subject;
            this.by_user_id = user;
            this.creationDate = DateTime.Now;
            this.questions = new List<Question>();
            this.quiz_id = -1;
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
        public void SetQuiz_id(int q_id)
        {
            this.quiz_id = q_id;
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
        public int GetQuiz_id()
        {
            return quiz_id;
        }

        //Handle question list//
        public void AddQuestion(Question question, int subject)
        {
            questions.Add(question);
        }

        public void ChangeQuestion(Question question, int pos)
        {
            questions[pos] = null;
            questions[pos] = question;
        }

        public void RemoveQuestion(int position)
        {
            questions.RemoveAt(position);
        }
    }
}
