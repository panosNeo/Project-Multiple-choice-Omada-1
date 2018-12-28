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

        //προσθήκη question
        public static void AddNewQuestion(string questionName, Answer[] answers)
        {
            myQuestion = new Question(questionName, myQuiz.GetUser_id(),myQuiz.GetSubject_id() , myQuiz.GetCreationDate());
            foreach(Answer an in answers)
            {
                myQuestion.AddAnswer(an);
            }
            myQuiz.AddQuestion(myQuestion, myQuiz.GetSubject_id());
        }
    }
}
