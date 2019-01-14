using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.MultipleChoiceDataSetTableAdapters;
using QuizMaker.QuizHandler;


namespace QuizMaker.SearchHandler
{
    class SearchController
    {
        public static TreeNode GetSubjects()
        {
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            List<MultipleChoiceDataSet.SubjectRow> lrow = new List<MultipleChoiceDataSet.SubjectRow>();
            foreach (var d in subject.GetData())
                lrow.Add(d);
            SubjectStack sub = new SubjectStack();
            SubjectStack temp = new SubjectStack();
            SortArray(lrow);
            foreach (var d in lrow) 
            {
                
                
                if(d.Root_id == 0)
                {
                    sub = new SubjectStack(d.Subject_id, d.Root_id, d.S_name);
                }
                
                else if(d.Root_id == 1)
                {
                    sub.PushStack(new SubjectStack(d.Subject_id, d.Root_id, d.S_name));
                }
                else
                {
                    temp = sub.GetSubWithID(d.Root_id, sub.after);
                    //Console.WriteLine(temp.subId);
                    if(temp != null)
                    {
                        temp.PushStack(new SubjectStack(d.Subject_id, d.Root_id, d.S_name));
                        foreach (SubjectStack test in temp.after)
                            Console.WriteLine(test.subName);
                        sub.ReplaceSub(d.Root_id, temp, sub.after);
                    }
                    
                }
                

            }
            return SeeThroughStack(sub);
        }
        private static TreeNode SeeThroughStack(SubjectStack sss)
        {
            var dtemp = new TreeNode(sss.subName);
            dtemp.Tag = sss.subId;
            foreach(SubjectStack temp in sss.after)
            {
                
                if (!temp.IsLeaf())
                {
                    var stemp = SeeThroughStack(temp);
                    stemp.Tag = temp.subId;
                    dtemp.Nodes.Add(stemp);
                }
            }
            foreach (SubjectStack temp in sss.after)
            {
                if (temp.IsLeaf())
                {
                    var stemp = new TreeNode(temp.subName);
                    stemp.Tag = temp.subId;
                    dtemp.Nodes.Add(stemp);
                }
            }
            return dtemp;
        }
        private static List<MultipleChoiceDataSet.SubjectRow> SortArray(List<MultipleChoiceDataSet.SubjectRow> l)
        {
            MultipleChoiceDataSet.SubjectRow temp;

            for (int write = 0; write < l.Count; write++)
            {
                for (int sort = 0; sort < l.Count - 1; sort++)
                {
                    if (l[sort].Root_id > l[sort + 1].Root_id)
                    {
                        temp = l[sort + 1];
                        l[sort + 1] = l[sort];
                        l[sort] = temp;
                    }
                }
            }
            
            return l;

        }
        public static List<QuizHandler.Quiz> GetQuizDataFromSubject(int subID)
        {
            QuizTableAdapter quizData = new QuizTableAdapter();
            QuestionTableAdapter questionData = new QuestionTableAdapter();
            AnswerTableAdapter answerData = new AnswerTableAdapter();
            List<Quiz> quizzes = new List<Quiz>();
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();

            foreach (MultipleChoiceDataSet.QuizRow q in quizData.GetData())
            {
                if (q.Subject_id == subID)
                {
                    quizzes.Add(new Quiz(q.Title, q.Subject_id, q.By_user));
                    foreach (MultipleChoiceDataSet.QuestionRow question in questionData.GetDataByQuizID(q.Quiz_id))
                    {
                        
                        if (question.Quiz_id == q.Quiz_id)
                        {
                            Question tempq = new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now);
                            //questions.Add(new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now));
                            foreach (MultipleChoiceDataSet.AnswerRow an in answerData.GetDataBy(question.Question_id))
                            {
                                //answers.Add(new Answer(an.Answer,an.Correct));
                                    tempq.AddAnswer(new Answer(an.Answer, an.Correct));
                            }
                            quizzes[quizzes.Count - 1].AddQuestion(tempq, question.Subject_id);
                        }
                        
                        
                    }
                }
                
            }
            return quizzes;
        }
        public static Quiz GetQuizByID(int subID)
        {
            QuizTableAdapter quizData = new QuizTableAdapter();
            QuestionTableAdapter questionData = new QuestionTableAdapter();
            
            AnswerTableAdapter answerData = new AnswerTableAdapter();
            Quiz quizzes = new Quiz();
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();

            foreach (MultipleChoiceDataSet.QuizRow q in quizData.GetData())
            {
                if (q.Quiz_id == subID)
                {
                    quizzes = new Quiz(q.Title, q.Subject_id, q.By_user);
                    foreach (MultipleChoiceDataSet.QuestionRow question in questionData.GetDataByQuizID(q.Quiz_id))
                    {
                        
                        if (question.Quiz_id == q.Quiz_id)
                        {
                            Question tempq = new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now);
                            //questions.Add(new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now));
                            foreach (MultipleChoiceDataSet.AnswerRow an in answerData.GetDataBy(question.Question_id))
                            {
                                //answers.Add(new Answer(an.Answer,an.Correct));
                                tempq.AddAnswer(new Answer(an.Answer, an.Correct));
                            }
                            quizzes.AddQuestion(tempq, question.Subject_id);
                        }

                        

                    }
                }

            }
            return quizzes;
        }
        public static List<Quiz> GetQuizByUserID(int subID)
        {
            QuizTableAdapter quizData = new QuizTableAdapter();
            QuestionTableAdapter questionData = new QuestionTableAdapter();
            AnswerTableAdapter answerData = new AnswerTableAdapter();
            List<Quiz> quizzes = new List<Quiz>();
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();

            foreach (MultipleChoiceDataSet.QuizRow q in quizData.GetData())
            {
                if (q.By_user == subID)
                {
                    quizzes.Add(new Quiz(q.Title, q.Subject_id, q.By_user));
                    foreach (MultipleChoiceDataSet.QuestionRow question in questionData.GetDataByQuizID(q.Quiz_id))
                    {
                        
                        if (question.Quiz_id == q.Quiz_id)
                        {
                            Question tempq = new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now);
                            //questions.Add(new Question(question.Question, question.By_user, question.Subject_id, DateTime.Now));
                            foreach (MultipleChoiceDataSet.AnswerRow an in answerData.GetDataBy(question.Question_id))
                            {
                                //answers.Add(new Answer(an.Answer,an.Correct));
                                tempq.AddAnswer(new Answer(an.Answer, an.Correct));
                            }
                            quizzes[quizzes.Count - 1].AddQuestion(tempq, question.Subject_id);
                        }

                        

                    }
                }

            }
            return quizzes;
        }
        public static void SetSubjects()
        {
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();

            //subject.InsertQueryWithID(13, 7, "HTML");//13
            //subject.InsertQueryWithID(14, 7, "Java");//14
            //subject.InsertQueryWithID(15, 7, "C#");//13
            //subject.InsertQueryWithID(16, 7, "Python");//13
            //subject.InsertQueryWithID(17, 14, "Recursion");//14
            //subject.InsertQueryWithID(18, 13, "CSS");//13
            //subject.InsertQueryWithID(19, 9, "Stars");//9
            //subject.InsertQueryWithID(1, 0, "Root");//1
            //subject.InsertQueryWithID(2, 1, "Technology");//2
            //subject.InsertQueryWithID(3, 1, "Physics");//3
            //subject.InsertQueryWithID(4, 1, "Math");//4
            //subject.InsertQueryWithID(5, 1, "History");//5
            //subject.InsertQueryWithID(6, 1, "Chemistry");//6
            //subject.InsertQueryWithID(7, 2, "Programming");//7
            //subject.InsertQueryWithID(8, 2, "Networking");//8
            //subject.InsertQueryWithID(9, 3, "AstroPhysics");//9
            //subject.InsertQueryWithID(10, 3, "Quantum Physics");//10
            //subject.InsertQueryWithID(11, 4, "Algebra");//11
            //subject.InsertQueryWithID(12, 4, "Geometry");//12

            foreach (MultipleChoiceDataSet.SubjectRow s in subject.GetData())
            {
                Console.WriteLine("Record ID: "+s.Subject_id);
            }

        }
    }
}
