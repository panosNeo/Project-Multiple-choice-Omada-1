using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.QuizHandler
{
    public class Answer
    {
        private string answer;
        private bool isCorrect;
        /*
        private int answer_id;
        private int question_id;
        */

        //CONSTRUCTOR, create Answer object//
        public Answer()
        {
        }
        public Answer(string an, bool isC)
        {
            this.answer = an;
            this.isCorrect = isC;
            /*
            this.answier_id=a_id;
            this.question_id=q_id;
            */
        }

        //SETTERS, change variables//
        public void SetAnswer(string an)
        {
            this.answer = an;
        }
        public void SetIsCorrect(bool isC)
        {
            this.isCorrect = isC;
        }

        public string GetAnswer()
        {
            return this.answer;
        }
        //Get if the answer is true or false//
        public bool IsCorrect()
        {
            return isCorrect;
        }
    }
}
