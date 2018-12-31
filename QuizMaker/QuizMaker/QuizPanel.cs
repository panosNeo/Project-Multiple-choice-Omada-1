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
        public QuizPanel()
        {
            InitializeComponent();
            questionCount = 0;
            quiz = new QuizPlayerController();
            userAnswers = new List<QuizAnswers>();
            SetInitialQuizPanel();
        }
        
        private void SetInitialQuizPanel()
        {
            string title = quiz.GetQuizTitle();
            Point p = new Point(0,0);
            QuizSwap temp;
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
        }

        private void SetNextQuestion(int pos)
        {
            answersHolder.Controls.Clear();
            questionHolder.Controls.Clear();
            QuizAnswers answer;
            Point p = new Point(30, 0);
            for(int i = 0; i < quiz.GetQuestionAnswersLength(pos); i++)
            {
                answer = new QuizAnswers(pos, i);
                answer.Location = p;
                answer.setAnswer(""+i, quiz.GetAnswerTitle(pos, i));
                answersHolder.Controls.Add(answer);
                p.Y += answer.Height;
            }
            string q = quiz.GetQuestionTitle(pos);
            QuizQuestion qu = new QuizQuestion();
            qu.setQuestion(q);
            questionHolder.Controls.Add(qu);
            questionCount++;
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            List<QuizAnswers> temp = new List<QuizAnswers>();
            //Αν υπαρχει εγγραφη απαντησεων για την συγκεκριμενη ερωτηση την αποθηκευουμε για να την διαγραψουμε   
            foreach(QuizAnswers listq in userAnswers)
            {
                if(listq.getQuestionNum() == questionCount-1)
                {
                    temp.Add(listq);
                }
            }
            foreach (QuizAnswers deleted in temp)
            {
                
                userAnswers.Remove(deleted);
                
            }
            foreach (QuizAnswers q in answersHolder.Controls)
            {
                userAnswers.Add(q);
            }
            
            
            if(questionCount >= quiz.GetQuestionLength())
            {
                Finish();
            }
            else {
                PaintSwapComponent(questionCount-1);
                SetNextQuestion(questionCount);
            }
            
        }
        
        private void swap_Click(object sender, EventArgs e)
        {
            questionCount = Convert.ToInt32(((Button)sender).Tag.ToString());
            
            SetNextQuestion(questionCount);
        }
        private void PaintSwapComponent(int pos)
        {
            foreach(QuizSwap c in questionSwapHolder.Controls)
            {
                if(c.PositionCounter == pos)
                {
                    c.SetButtonColor(Color.Blue);
                }
            }
        }

        private void Finish()
        {
            
            double sum = 0;
            double correctsum = 0;
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
                            }
                        }
                    }
                }
            }
            double success = correctsum / sum;
            Controls.Clear();
            Controls.Add(new QuizPlayScore("" + (success * 100) + @"%"));
        }

        private void printQuizBtn_Click(object sender, EventArgs e)
        {
            quiz.PrintThisQuiz();
        }
    }
}
