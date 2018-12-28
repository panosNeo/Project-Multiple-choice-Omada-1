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
                if(quizNameTextBox.Text!="")
                {
                    //αν είναι κενό το όνομα δεν συνεχίζεται 
                    CreateQuizControlHandler.SetQuiz(quizNameTextBox.Text, 0, 0);
                    SetEnabledPanels(1);
                }
            }else if (name.Equals("backBtn"))
            {
                SetEnabledPanels(0);
            }else if (name.Equals("finishQuestionsBtn"))
            {
                SetEnabledPanels(2);
            }
        }

        //το movePanelsPivot θέτεται ώστε να σταματήσει την λούπα των tick μόλις φτάσει την τιμή 350 
        private int movePanelsPivot = 0;
        private void createQuizTimer_Tick(object sender, EventArgs e)
        {
            if(movePanelsPivot < 350)
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

        List<Question> questions = new List<Question>();
        private int currentQuestion = 0;
        private void questionsBtn_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            if(name== "prevQuBtn")
            {

            }
            else if(name== "nextQuBtn")
            {

            }
            else if(name== "nextQuestionBtn")
            {
                List<Answer> ans = getAnswers();
                if(ans.Count==0 || !ListIsCompleted(getAnswers()))
                {
                    Console.WriteLine("adio");
                }
                else
                {
                    Console.WriteLine("exeis");
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
            foreach(Answer a in lis)
            {
                if(a.GetAnswer()=="")
                {
                    return false;
                }
            }
            return true;
        }
    }

}
