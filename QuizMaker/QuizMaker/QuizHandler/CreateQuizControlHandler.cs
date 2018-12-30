using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker;

namespace QuizMaker.QuizHandler
{
    class CreateQuizControlHandler
    {
        static Quiz myQuiz = new Quiz();
        static Question myQuestion = new Question();

        //δημιουργία καινούριου quiz
        public static void SetQuiz(string quizName,int subject,int user_id)
        {
            myQuiz = new Quiz(quizName, subject, user_id);
        }

        public static void AddQuestion(Question que)
        {
            myQuiz.AddQuestion(que,0);
        }

        //προσθήκη question
        public static void AddNewQuestion(string questionName, List<Answer> answers)
        {
            myQuestion = new Question(questionName, myQuiz.GetUser_id(),myQuiz.GetSubject_id() , myQuiz.GetCreationDate());
            foreach(Answer an in answers)
            {
                myQuestion.AddAnswer(an);
            }
            myQuiz.AddQuestion(myQuestion, myQuiz.GetSubject_id());
        }

        public static void RemoveQuestion(int index)
        {
            myQuiz.RemoveQuestion(index);
        }

        public static Question GetQuestion(int index)
        {
            return myQuiz.getQuestions()[index];
        }

        public static Quiz GetQuiz()
        {
            return myQuiz;
        }

        public static int CountQuests()
        {
            return myQuiz.getQuestions().Count;
        }
    }
}
