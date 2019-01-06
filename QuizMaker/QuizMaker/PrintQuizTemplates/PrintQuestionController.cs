using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.QuizHandler;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace QuizMaker.PrintQuizTemplates
{
    class PrintQuizController
    {
        
        
        private Quiz quiz;
        private List<FirstPage> firstPage = new List<FirstPage>();
        private PrintQuestion question;

        public PrintQuizController(Quiz q)
        {
            quiz = q;
            InitializePrint();
        }

        private void InitializePrint()
        {
            firstPage.Add(new FirstPage());
            firstPage.ElementAt<FirstPage>(firstPage.Count - 1).setTitle(quiz.GetQuizTitle());
            SetQuestions();
        }

        private void SetQuestions()
        {
            
            Point p = new Point(0,0);
            List<QuestionAnswer> tempPadding = new List<QuestionAnswer>();
            
            foreach (Question q in quiz.getQuestions())
            {
                question = new PrintQuestion();
                question.SetTitle(q.GetQuestion());
                if (p.Y >= firstPage.ElementAt<FirstPage>(firstPage.Count - 1).GetQuestionsSize().Height - question.Size.Height)
                {
                    p.Y = 0;
                    firstPage.Add(new FirstPage());
                    firstPage.Last().setTitle(quiz.GetQuizTitle());
                }
                firstPage.ElementAt<FirstPage>(firstPage.Count - 1).SetControlInQuestions(p, question);
                p.Y += question.Size.Height;
                foreach (Answer an in q.GetAnswers())
                {
                    
                    tempPadding.Add(new QuestionAnswer(an.GetAnswer()));
                    
                }
                if (tempPadding.Count > 0)
                {
                    foreach(QuestionAnswer pad in tempPadding)
                    {
                        if (p.Y >= firstPage.ElementAt<FirstPage>(firstPage.Count - 1).GetQuestionsSize().Height - question.Size.Height)
                        {
                            p.Y = 0;
                            firstPage.Add(new FirstPage());
                            firstPage.Last().setTitle(quiz.GetQuizTitle());
                        }
                        firstPage.ElementAt<FirstPage>(firstPage.Count - 1).SetControlInQuestions(p, pad);
                        p.Y += pad.Size.Height;
                    }
                    tempPadding.Clear();
                }
                
            }
            PrintQuiz();
        }

        private void PrintQuiz()
        {
            PrintForm p = new PrintForm(firstPage);
            p.Show();
            p.Hide();
            new PrintController().Print(p.First);
            p.Close();
        }

        
    }
}
