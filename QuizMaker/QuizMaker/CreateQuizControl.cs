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
        public CreateQuizControl(Size s)
        {
            InitializeComponent();
            this.Size = s;
        }
        private int panelPos = 0;
        private void movePanelsBtn_Click(object sender, EventArgs e)
        {
            panelPos = Convert.ToInt32(((Button)sender).Tag);
            createQuizTimer.Start();
        }

        private void createQuizTimer_Tick(object sender, EventArgs e)
        {
            switch (panelPos)
            {
                case 0:
                    break;
                case 1:
                    if(secondPanel.Location.X > 270)
                    {
                        secondPanel.Location = new Point(secondPanel.Location.X - 1, secondPanel.Location.Y);
                    }
                    break;
                case 2:
                    break;
            }
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
