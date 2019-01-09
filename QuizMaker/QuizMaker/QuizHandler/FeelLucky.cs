using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.QuizHandler
{
    class FeelLucky
    {
        private Random rnd = new Random();
        private int randomQuiz_id;
        private Quiz randomQuiz;

        public Quiz GetARandomQuiz(int numOfQuizs)
        {
            MultipleChoiceDataSetTableAdapters.QuizTableAdapter quizData = new MultipleChoiceDataSetTableAdapters.QuizTableAdapter();
            randomQuiz_id = rnd.Next((int)quizData.CountQuizes()) + 1;

            if ((int)quizData.CountQuizes() != 0)
            {
                randomQuiz = SearchHandler.SearchController.GetQuizByID(randomQuiz_id);
                return randomQuiz;
            }
            else
            {
                return new Quiz();
            }
        }
    }
}
