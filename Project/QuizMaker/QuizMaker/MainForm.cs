﻿using System;
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
        private bool menuVisible;
        public MainForm()
        {
            InitializeComponent();
            menuVisible = true;
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new LoginControl(mainPanel.Size));
        }

        private void menuVisibleBtn_Click(object sender, EventArgs e)
        {
            
            menuVisible = !menuVisible;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Size leftPanelSize = leftPanel.Size;
            Size mainPanelSize = mainPanel.Size;
            Point mainPanelLocation = mainPanel.Location;
            if (!menuVisible)
            {
                if (leftPanelSize.Width >= 32)
                {
                    leftPanelSize.Width = leftPanelSize.Width - 5;
                   // mainPanelSize.Width = mainPanelSize.Width + 5;
                    //mainPanelLocation.X = mainPanelLocation.X - 5;
                    leftPanel.Size = leftPanelSize;
                    //mainPanel.Size = mainPanelSize;
                    //mainPanel.Location = mainPanelLocation;
                }
                else timer1.Stop();
            }
            else
            {
                if (leftPanelSize.Width <= 165)
                {
                    leftPanelSize.Width = leftPanelSize.Width + 5;
                    //mainPanelSize.Width = mainPanelSize.Width - 5;
                    //mainPanelLocation.X = mainPanelLocation.X + 5;
                    leftPanel.Size = leftPanelSize;
                    //mainPanel.Size = mainPanelSize;
                    //mainPanel.Location = mainPanelLocation;
                }
                else timer1.Stop();
            }
        }

        private void setButtonsVisible(bool v)
        {
            categoriesBtn.Visible = v;
            feelLuckyBtn.Visible = v;
            createQuizBtn.Visible = v;
        }

        private void LeftMenuButtons_Click(object sender, EventArgs e)
        {
            string panelName = ((Button)sender).Tag.ToString();
            ChangePanel(panelName);
        }
        private void ChangePanel(string name)
        {
            mainPanel.Controls.Clear();
            switch (name)
            {
                case "createQuiz":
                    mainPanel.Controls.Add(new CreateQuizControl(mainPanel.Size));
                    break;
                case "categories":
                    mainPanel.Controls.Add(new CategoriesControl(mainPanel.Size));
                    break;
                case "feelLucky":
                    mainPanel.Controls.Add(new FeelLuckyControl(mainPanel.Size));
                    break;
                default:
                    Console.WriteLine("No control selected");
                    break;
            }

        }
    }
}
