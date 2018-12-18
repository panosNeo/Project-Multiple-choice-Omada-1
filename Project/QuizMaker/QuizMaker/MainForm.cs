using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            changePanel();
            changePanel();

        }

        public void changePanel()
        {
            mainPanel.Controls.Add(new StartControl(mainPanel.Size));
        }
    }
}
