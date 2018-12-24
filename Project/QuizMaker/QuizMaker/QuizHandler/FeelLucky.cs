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
            randomQuiz_id = rnd.Next(numOfQuizs);
            //methodos pou tha psaxnei stin basi me basi to randomQuiz_id kai tha epistrefei to quiz//
            return randomQuiz;
        }
    }
}
