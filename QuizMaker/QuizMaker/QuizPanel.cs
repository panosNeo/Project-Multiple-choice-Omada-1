using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.QuizHandler;
using QuizMaker.PlayQuizTemplates;

namespace QuizMaker
{
    public partial class QuizPanel : UserControl
    {
        private QuizPlayerController quiz;
        private int questionCount;
        private List<QuizAnswers> userAnswers;
        public QuizPanel(QuizPlayerController q)
        {
            InitializeComponent();
            questionCount = 0;
            quiz = q;
            userAnswers = new List<QuizAnswers>();
            SetInitialQuizPanel();
        }
        
        private void SetInitialQuizPanel()
        {
            string title = quiz.GetQuizTitle();
            Point p = new Point(0,0);
            QuizSwap temp;
            //set the buttons under the question that will be used for changing back and forth the questions
            for(int i = 0; i < quiz.GetQuestionLength(); i++)
            {
                temp = new QuizSwap(i);
                temp.Location = p;
                temp.PositionCounter = i;
                temp.Controls.Find("questionBtn", true)[0].Click += swap_Click;
                questionSwapHolder.Controls.Add(temp);
                
                p.X += 50;
            }
            quizTitleLabel.Text = title;
            SetNextQuestion(0);
            SetFocusSwapComponent(0);
        }

        private void SetNextQuestion(int pos)
        {
            answersHolder.Controls.Clear();
            questionHolder.Controls.Clear();
            QuizAnswers answer;
            Point p = new Point(30, 0);
            //dynamically setting the answers for each question
            for(int i = 0; i < quiz.GetQuestionAnswersLength(pos); i++)
            {
                answer = new QuizAnswers(pos, i);
                answer.Location = p;
                answer.setAnswer(""+i, quiz.GetAnswerTitle(pos, i));
                if (i % 2 == 0)
                    answer.BackColor = Color.FromArgb(37, 46, 69);
                answersHolder.Controls.Add(answer);
                p.Y += answer.Height;
            }
            string q = quiz.GetQuestionTitle(pos);
            QuizQuestion qu = new QuizQuestion();
            qu.setQuestion(q);
            questionHolder.Controls.Add(qu);
            
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            List<QuizAnswers> temp = new List<QuizAnswers>();
            //If there is an older record of the user answer in this question, we remove it and save the new answer   
            //Find
            foreach (QuizAnswers listq in userAnswers)
            {
                if(listq.getQuestionNum() == questionCount)
                {
                    temp.Add(listq);
                }
            }
            //Remove
            foreach (QuizAnswers deleted in temp)
            {
                
                userAnswers.Remove(deleted);
                
            }
            //Save new answer
            foreach (QuizAnswers q in answersHolder.Controls)
            {
                userAnswers.Add(q);
            }
            
            //User answered all questions
            if(questionCount >= quiz.GetQuestionLength() - 1)
            {
                finishBtn.Visible = true;
                PaintSwapComponent(questionCount);
            }
            else {
                questionCount++;
                PaintSwapComponent(questionCount-1);
                SetNextQuestion(questionCount);
                SetFocusSwapComponent(questionCount);
            }
            
        }
        
        private void swap_Click(object sender, EventArgs e)
        {
            //In the Tag of each QuizSwap button exists the number of the question to redirect
            questionCount = Convert.ToInt32(((Button)sender).Tag.ToString());
            
            //Redirect to the question n. where n = Tag of sender(QuizSwap)
            SetNextQuestion(questionCount);

            SetFocusSwapComponent(questionCount);
        }

        private void SetFocusSwapComponent(int pos)
        {
            foreach (QuizSwap c in questionSwapHolder.Controls)
            {
                if (c.PositionCounter == pos)
                {
                    c.SetButtonColor(Color.Red);
                }
                else if (!c.Answered)
                {
                    c.SetButtonColor(Color.LightGray);
                }
                else
                {
                    c.SetButtonColor(Color.Blue);
                }
            }
        }
        private void PaintSwapComponent(int pos)
        {
            bool answered = false;
            foreach(QuizAnswers q in userAnswers)
            {
                if (q.getAnswer() && q.getQuestionNum() == pos)
                {
                    answered = true;
                    break;
                }
            }
            foreach(QuizSwap c in questionSwapHolder.Controls)
            {
                if(c.PositionCounter == pos && answered)
                {
                    c.SetButtonColor(Color.Blue);
                    c.Answered = answered;
                }
            }
        }

        private void Finish()
        {
            //this code used to calculate the score. Needs to be more dynamic. 
            double sum = 0;
            double correctsum = 0;
            double falsesum = 0;
            for(int i = 0; i < quiz.GetQuestionLength(); i++)
            {
                for(int k = 0; k < quiz.GetQuestionAnswersLength(i); k++)
                {
                    if (quiz.IsCorrect(i, k))
                    {
                        sum++;
                        foreach(QuizAnswers ans in userAnswers)
                        {
                            if(ans.getQuestionNum() == i && ans.getAnswerNum() == k)
                            {
                                if (ans.getAnswer())
                                {
                                    correctsum++;
                                }
                            }else if(ans.getQuestionNum() == i && ans.getAnswerNum() != k)
                            {
                                if (ans.getAnswer())
                                {
                                    falsesum++;
                                }
                            }
                        }
                    }
                }
            }
            double success = (correctsum - (falsesum/2)) / sum;
            Controls.Clear();
            QuizPlayScore qp = new QuizPlayScore("" + (success * 100) + @"%",quiz);
            qp.Dock = DockStyle.Fill;
            Controls.Add(qp);
        }

        private void printQuizBtn_Click(object sender, EventArgs e)
        {
            quiz.PrintThisQuiz();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Finish();
        }
    }
}
