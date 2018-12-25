using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class CreateQuizControl : UserControl
    {
        public CreateQuizControl()
        {
            InitializeComponent();
            
        }
        private int panelPos = 0;
        private void movePanelsBtn_Click(object sender, EventArgs e)
        {
            panelPos = Convert.ToInt32(((Button)sender).Tag);
            createQuizTimer.Start();
            string name = ((Button)sender).Name;
            if (name.Equals("stepOneNextBtn"))
            {
                SetEnabledPanels(1);
            }else if (name.Equals("backBtn"))
            {
                SetEnabledPanels(0);
            }else if (name.Equals("finishQuestionsBtn"))
            {
                SetEnabledPanels(2);
            }
        }
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
    }
}
