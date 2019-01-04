
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.QuizHandler;
using QuizMaker.PlayQuizTemplates;

namespace QuizMaker
{
    class QuizPlayerController
    {
        private QuizHandler.Quiz quiz;
        private int questionCount;
        private List<QuizAnswers> userAnswers;

        public QuizPlayerController()
        {
            setATestQuiz();
        }

        private void setATestQuiz()
        {
            quiz = new Quiz("My test quiz", 0, 0);
            for (int i = 0; i < 10; i++)
            {
                Question q = new Question("TEST1" + i, i, i, DateTime.Now);
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quizMy test quizMy test quizMy test quiztestMy test quizMy test quizMy test quizMy test quizMy test quizMy test quiztestMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quiz" + i, true));
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quiz" + i, false));
                q.AddAnswer(new Answer("test" + i, false));
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quiz" + i, false));
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quizMy test quiz" + i, false));
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quizMy test quizMy test quiz" + i, false));
                q.AddAnswer(new Answer("testMy test quizMy test quizMy test quizMy test quiz" + i, false));
                quiz.AddQuestion(q, 1);
            }
        }
        public string GetQuizTitle()
        {
            return quiz.GetQuizTitle();
        }
        public int GetQuestionLength()
        {
            return quiz.getQuestions().Count;
        }

        public int GetQuestionAnswersLength(int i)
        {
            return quiz.getQuestions().ElementAt<Question>(i).GetAnswers().Count;
        }

        public string GetQuestionTitle(int i)
        {
            return i+") " + quiz.getQuestions().ElementAt<Question>(i).GetQuestion();
        }

        public string GetAnswerTitle(int questionNum, int answerNum)
        {
            return quiz.getQuestions().ElementAt<Question>(questionNum).GetAnswers().ElementAt<Answer>(answerNum).GetAnswer();
        }

        public bool IsCorrect(int question, int answer)
        {
            return quiz.getQuestions().ElementAt<Question>(question).GetAnswers().ElementAt<Answer>(answer).IsCorrect();
        }

        public void PrintThisQuiz()
        {
            new PrintQuizTemplates.PrintQuizController(quiz);
        }
    }
}

