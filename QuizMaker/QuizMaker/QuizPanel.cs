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
        private QuizHandler.Quiz quiz;
        private int questionCount;
        private List<QuizAnswers> userAnswers;
        public QuizPanel()
        {
            InitializeComponent();
            questionCount = 0;
            quiz = new Quiz();
            userAnswers = new List<QuizAnswers>();
            setATestQuiz();
            SetInitialQuizPanel();
        }
        private void setATestQuiz()
        {
            quiz = new Quiz("My test quiz", 0, 0);
            for(int i = 0; i < 10; i++)
            {
                Question q = new Question("test question"+i, i, i, DateTime.Now);
                q.AddAnswer(new Answer("test"+i, true));
                q.AddAnswer(new Answer("test" + i, false));
                q.AddAnswer(new Answer("test" + i, false));
                q.AddAnswer(new Answer("test" + i, false));
                quiz.AddQuestion(q, 1);
            }
        }
        private void SetInitialQuizPanel()
        {
            string title = quiz.GetQuizTitle();
            Point p = new Point(0,0);
            QuizSwap temp;
            int counter = 0;
            foreach(Question q in quiz.getQuestions())
            {
                temp = new QuizSwap(counter);
                temp.Location = p;
                temp.PositionCounter = counter;
                temp.Controls.Find("questionBtn", true)[0].Click += swap_Click;
                questionSwapHolder.Controls.Add(temp);
                
                p.X += 50;
                counter++;
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
            int counter = 1;
            int answerCounter = 0;
            foreach(Answer a in quiz.getQuestions().ElementAt<Question>(pos).GetAnswers())
            {
                answer = new QuizAnswers(counter-1, answerCounter);
                answerCounter++;
                answer.Location = p;
                answer.setAnswer(""+counter, a.GetAnswer());
                answersHolder.Controls.Add(answer);
                p.Y += 50;
            }
            string q = quiz.getQuestions().ElementAt<Question>(pos).GetQuestion();
            QuizQuestion qu = new QuizQuestion();
            qu.setQuestion("" + pos, q);
            questionHolder.Controls.Add(qu);
            questionCount++;
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            bool equal = false;
            foreach(QuizAnswers q in answersHolder.Controls)
            {
                foreach(QuizAnswers listq in userAnswers)
                {
                    if(q.Equals(listq))
                    {
                        equal = true;
                        break;
                    }
                }
                if (!equal)
                {
                    userAnswers.Add(q);
                }
            }
            if(questionCount >= quiz.getQuestions().Count)
            {
                Finish();
            }
            else {
                PaintSwapComponent(questionCount-1);
                SetNextQuestion(questionCount);
            }
            
        }
        private void CheckCorrect(int i)
        {
            foreach(Answer an in quiz.getQuestions().ElementAt<Question>(i).GetAnswers())
            {
                
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
            int question;
            int answer;
            double sum = 0;
            double correctsum = 0;
            foreach(QuizAnswers uAnswers in userAnswers)
            {
                question = uAnswers.getQuestionNum();
                answer = uAnswers.getAnswerNum();
                bool cor = quiz.getQuestions().ElementAt<Question>(question).GetAnswers().ElementAt(answer).IsCorrect();
                if (cor)
                {
                    sum++;
                }
                if(uAnswers.getAnswer().Equals(cor) && cor)
                {
                    correctsum++;
                }
            }
            double success = correctsum / sum;
            Controls.Clear();
            Controls.Add(new QuizPlayScore("" + (success * 100) + @"%"));
        }
        
    }
}
