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

namespace QuizMaker
{
    public partial class CreateQuizControl : UserControl
    {

        public CreateQuizControl()
        {
            InitializeComponent();
            setElementAtTreeView();
        }

        private void setElementAtTreeView()
        {
            tagTreeView.Nodes.Clear();
            tagTreeView.Nodes.Add(SearchHandler.SearchController.GetSubjects());
        }

        //ορίζουμε την μεταβλητή panelPos ώστε να θέσουμε κίνηση προς τα αριστερά ή δεξιά
        private int panelPos = 0;
        //ορίζουμε την παρακάτω μέθοδο που καλείται όταν πατηθεί ένα από τα κουμπιά που μετακινούν τα panel
        private void movePanelsBtn_Click(object sender, EventArgs e)
        {
            //ως tag ορίζουμε την κίνηση των panel που θα γίνει(τιμές που παίρνει: -5,5)
            panelPos = Convert.ToInt32(((Button)sender).Tag);
            //ξεχωρίζουμε τα button που κάλεσαν το event για περαιτέρω επεξεργασία(αποθήκευση τιμών κλπ)
            string name = ((Button)sender).Name;
            if (name.Equals("stepOneNextBtn"))
            {
                if (quizNameTextBox.Text != "" /*&& tagTreeView.SelectedNode.Tag !=null*/)
                {
                    //αν είναι κενό το όνομα δεν συνεχίζεται 
                    CreateQuizControlHandler.SetQuiz(quizNameTextBox.Text, 0, 0);
                    SetEnabledPanels(1);
                }
            }
            else if (name.Equals("backBtn"))
            {
                if (MessageBox.Show("Do you want to delete this QUIZ ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CreateQuizControlHandler.SetQuiz();
                    currentQuestion = 0;
                    NewEmptyQuestion();
                    CheckQuestionNum();
                    lastQuestion = new Question();
                    lastQuestionBool = false;
                    SetEnabledPanels(0);
                }
            }
            else if (name.Equals("finishQuestionsBtn"))
            {
                if (FinishButton())
                    SetEnabledPanels(2);
            }
        }

        //το movePanelsPivot θέτεται ώστε να σταματήσει την λούπα των tick μόλις φτάσει την τιμή 350 
        private int movePanelsPivot = 0;
        private void createQuizTimer_Tick(object sender, EventArgs e)
        {
            if (movePanelsPivot < 350)
            {
                movePanels(panelPos);
                movePanelsPivot += Math.Abs(panelPos);
            }
            else
            {
                movePanelsPivot = 0;
                createQuizTimer.Stop();
            }
        }
        private void movePanels(int pivot)
        {
            firstPanel.Location = new Point(firstPanel.Location.X + pivot, firstPanel.Location.Y);
            secondPanel.Location = new Point(secondPanel.Location.X + pivot, secondPanel.Location.Y);
            thirdPanel.Location = new Point(thirdPanel.Location.X + pivot, thirdPanel.Location.Y);
        }
        private void SetEnabledPanels(int panel)
        {
            createQuizTimer.Start(); // timer για το animation
            firstPanel.Enabled = false;
            secondPanel.Enabled = false;
            thirdPanel.Enabled = false;
            switch (panel)
            {
                case 0:
                    firstPanel.Enabled = true;
                    break;
                case 1:
                    secondPanel.Enabled = true;
                    break;
                case 2:
                    thirdPanel.Enabled = true;
                    break;
            }
        }


        private Question lastQuestion = new Question();
        private bool lastQuestionBool = false;
        private int currentQuestion = 1;
        private void newQuestionsBtn_Click(object sender, EventArgs e)
        {
            List<Answer> ans = getAnswers();
            if (ans.Count == 0 || !ListIsCompleted(getAnswers()) || questionNameTextBox.Text == "")
            {
                Console.WriteLine("adio");
            }
            else
            {
                NewEmptyQuestion();
            }
            CheckQuestionNum();
        }

        private void NewEmptyQuestion()
        {
            int allQ = CreateQuizControlHandler.CountQuests();
            if (allQ <= currentQuestion)
            {
                if (currentQuestion != allQ)
                {
                    CreateQuizControlHandler.AddNewQuestion(questionNameTextBox.Text, getAnswers());
                }
                currentQuestion += 1;
                List<Answer> nullAns = new List<Answer>();
                SetQuestionPanelVar("", nullAns, currentQuestion);
            }
        }

        public void nextQBtn_Click(object sender, EventArgs e)
        {
            int allQ = CreateQuizControlHandler.CountQuests();
            CreateQuizControlHandler.ChangeQuestionIn(currentQuestion - 1, questionNameTextBox.Text, getAnswers());
            currentQuestion += 1;
            CheckQuestionNum();
            if (currentQuestion > allQ)
            {
                SetQuestionPanelVar(lastQuestion.GetQuestion(), lastQuestion.GetAnswers(), currentQuestion);
            }
            else
            {
                SetQuestionPanelVar(CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetQuestion(), CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetAnswers(), currentQuestion);
            }

        }
        public void prevQBtn_click(object sender, EventArgs e)
        {
            if (currentQuestion > CreateQuizControlHandler.CountQuests())
            {
                SaveLastQuestion();
            }
            else
            {
                CreateQuizControlHandler.ChangeQuestionIn(currentQuestion - 1, questionNameTextBox.Text, getAnswers());
            }
            currentQuestion -= 1;
            CheckQuestionNum();
            SetQuestionPanelVar(CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetQuestion(), CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetAnswers(), currentQuestion);
        }

        public void deleteQBtn_Click(object sender, EventArgs e)
        {
            int allQ = CreateQuizControlHandler.CountQuests();

            if (allQ != 0)
            {
                if (allQ < currentQuestion)
                {
                    lastQuestionBool = false;
                    lastQuestion = new Question();
                    currentQuestion -= 1;
                }
                else
                {
                    currentQuestion -= 1;
                    CreateQuizControlHandler.RemoveQuestion(currentQuestion);
                }
                if (currentQuestion == 0)
                {
                    currentQuestion = 1;
                    if (allQ <= 1)
                    {
                        if (!lastQuestionBool)
                        {
                            List<Answer> nullAns = new List<Answer>();
                            SetQuestionPanelVar("", nullAns, 1);
                        }
                        else
                        {
                            SetQuestionPanelVar(lastQuestion.GetQuestion(), lastQuestion.GetAnswers(), currentQuestion);
                        }
                    }
                    else
                    {
                        Console.WriteLine("asd");
                        SetQuestionPanelVar(CreateQuizControlHandler.GetQuestion(currentQuestion-1).GetQuestion(), CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetAnswers(), currentQuestion);
                    }
                }
                else
                {
                    SetQuestionPanelVar(CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetQuestion(), CreateQuizControlHandler.GetQuestion(currentQuestion - 1).GetAnswers(), currentQuestion);
                }
                CheckQuestionNum();
            }
        }

        private void SaveLastQuestion()
        {
            lastQuestionBool = true;
            List<Answer> ans = getAnswers();
            Quiz myq = CreateQuizControlHandler.GetQuiz();
            lastQuestion = new Question(questionNameTextBox.Text, myq.GetUser_id(), myq.GetSubject_id(), myq.GetCreationDate());
            foreach (Answer an in ans)
            {
                lastQuestion.AddAnswer(an);
            }
        }

        private void SetQuestionPanelVar(string questionName, List<Answer> ans, int questionNum)
        {
            questionNameTextBox.Text = questionName;
            questionNumber.Text = questionNum + "";
            List<AnswerPanel> ap = new List<AnswerPanel>();

            foreach (Control p in AnswersPanel.Controls)
            {
                if (p.GetType().ToString() == "QuizMaker.AnswerPanel")
                {
                    ap.Add((AnswerPanel)p);
                }
            }

            ResetAnswers(ap);

            foreach (Answer a in ans)
            {
                AnswerPanel aP = new AnswerPanel();
                aP.SetAnswerName(a.GetAnswer());
                aP.SetCorrection(a.IsCorrect());
                aP.Location = nextAnswerBtn.Location;

                //μετακινηση των κουμπιών + και - προς τα κατω
                nextAnswerBtn.Location = new Point(nextAnswerBtn.Location.X, nextAnswerBtn.Location.Y + 33);
                delAnswerBtn.Location = new Point(delAnswerBtn.Location.X, delAnswerBtn.Location.Y + 33);
                AnswersPanel.Controls.Add(aP);
            }
        }
        private void ResetAnswers(List<AnswerPanel> ap)
        {
            foreach (AnswerPanel a in ap)
            {
                a.Dispose();
                //μετακινηση των κουμπιών + και - προς τα πανω
                nextAnswerBtn.Location = new Point(nextAnswerBtn.Location.X, nextAnswerBtn.Location.Y - 33);
                delAnswerBtn.Location = new Point(delAnswerBtn.Location.X, delAnswerBtn.Location.Y - 33);
            }
        }

        private void CheckQuestionNum()
        {
            Console.WriteLine(lastQuestionBool);
            int allQ = CreateQuizControlHandler.CountQuests();
            Console.WriteLine(allQ + " " + currentQuestion);
            if (allQ == 0)
            {
                prevQuBtn.Enabled = false;
                nextQuBtn.Enabled = false;
            }
            else if (currentQuestion > allQ)
            {
                prevQuBtn.Enabled = true;
                nextQuBtn.Enabled = false;
            }
            else
            {
                if (currentQuestion == allQ)
                {
                    nextQuBtn.Enabled = lastQuestionBool;
                }
                else
                {
                    nextQuBtn.Enabled = true;
                }
                if (currentQuestion == 1)
                {
                    prevQuBtn.Enabled = false;
                }
                else
                {
                    prevQuBtn.Enabled = true;
                }

            }
        }

        private void nextAnswerBtn_Click(object sender, EventArgs e)
        {
            AnswerPanel ap = new AnswerPanel();
            ap.Location = ((Button)sender).Location;

            //μετακινηση των κουμπιών + και - προς τα κατω
            nextAnswerBtn.Location = new Point(nextAnswerBtn.Location.X, nextAnswerBtn.Location.Y + 33);
            delAnswerBtn.Location = new Point(delAnswerBtn.Location.X, delAnswerBtn.Location.Y + 33);
            AnswersPanel.Controls.Add(ap);
        }
        private void delAnswerBtn_Click(object sender, EventArgs e)
        {
            AnswerPanel ap = new AnswerPanel();
            ap = null;
            foreach (Control p in AnswersPanel.Controls)
            {
                if (p.GetType().ToString() == "QuizMaker.AnswerPanel")
                {
                    ap = (AnswerPanel)p;
                }
            }
            if (ap != null)
            {
                ap.Dispose();
                //μετακινηση των κουμπιών + και - προς τα πανω
                nextAnswerBtn.Location = new Point(nextAnswerBtn.Location.X, nextAnswerBtn.Location.Y - 33);
                delAnswerBtn.Location = new Point(delAnswerBtn.Location.X, delAnswerBtn.Location.Y - 33);
            }
        }

        private List<Answer> getAnswers()
        {
            List<Answer> ans = new List<Answer>();

            AnswerPanel ap = new AnswerPanel();
            ap = null;
            foreach (Control p in AnswersPanel.Controls)
            {
                if (p.GetType().ToString() == "QuizMaker.AnswerPanel")
                {
                    ap = (AnswerPanel)p;
                    Answer an = new Answer(ap.GetAnswerName(), ap.GetCorrection());
                    ans.Add(an);
                }
            }
            return ans;
        }
        private bool ListIsCompleted(List<Answer> lis)
        {
            foreach (Answer a in lis)
            {
                if (a.GetAnswer() == "")
                {
                    return false;
                }
            }
            return true;
        }

        private bool FinishButton()
        {
            int allQ = CreateQuizControlHandler.CountQuests();
            if (MessageBox.Show("Do you want to finish this QUIZ ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (allQ < currentQuestion)
                {
                    SaveLastQuestion();
                    List<Answer> ans = getAnswers();
                    if (ans.Count == 0 || !ListIsCompleted(getAnswers()) || questionNameTextBox.Text == "")
                    {
                        MessageBox.Show("Please don't leave empty spaces");
                        return false;
                    }
                    CreateQuizControlHandler.AddNewQuestion(lastQuestion.GetQuestion(), ans);
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        private void finishQuizBtn_Click(object sender, EventArgs e)
        {
            PrintQuizTemplates.PrintQuizController print = new PrintQuizTemplates.PrintQuizController(CreateQuizControlHandler.GetQuiz());
        }
    }
}
