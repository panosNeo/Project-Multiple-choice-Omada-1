using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.SearchHandler
{
    public class RetreivedQuiz
    {
        public int quizID { get; set; }
        public string quizName { get; set; }
        public string quizSubject { get; set; }
        public int questionsCount { get; set; }
        public int likes { get; set; }
        public int dislikes { get; set; }

        public RetreivedQuiz(int id, string name, string subject, int questions) {
            quizID = id;
            quizName = name;
            quizSubject = subject;
            questionsCount = questions;
        }
        override
        public String ToString()
        {
            return quizID + " " + quizName;
        }

        
    }
}
