﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class SubjectControl : UserControl
    {
        //subject list
        private List<SubjectHandler.Subject> subjects;

        public SubjectControl()
        {
            InitializeComponent();
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {
            //kane search gia ta subjects pou uparxoun
            SubjectHandler.SubjectController.SearchForExistingSubjects();
            //gemise th lista
            FillSubjectList();

            //gemise to subject treeView me ola ta subjects
            FillExistingSubjectsID();
        }

        private void QuizSettingsButton_Click(object sender, EventArgs e)
        {
            //kane enabled kai readOnly ta components
            if (qSubIDBox.ReadOnly)
            {
                qSubIDBox.ReadOnly = false;
                qQuizIDBox.ReadOnly = false;
                qUserIDBox.ReadOnly = false;
                qQuizNameBox.ReadOnly = false;
                qDateBox.ReadOnly = false;

                QuizAdd.Enabled = true;
                QuizDelete.Enabled = true;
                QuizUpdate.Enabled = true;
                QuizReset.Enabled = true;
            }
            else
            {
                qSubIDBox.ReadOnly = true;
                qQuizIDBox.ReadOnly = true;
                qUserIDBox.ReadOnly = true;
                qQuizNameBox.ReadOnly = true;
                qDateBox.ReadOnly = true;

                QuizAdd.Enabled = false;
                QuizDelete.Enabled = false;
                QuizUpdate.Enabled = false;
                QuizReset.Enabled = false;
            }
        }

        private void QuizReset_Click(object sender, EventArgs e)
        {
            qSubIDBox.Text = "";
            qQuizIDBox.Text = "";
            qUserIDBox.Text = "";
            qQuizNameBox.Text = "";
            qDateBox.Text = "";
        }

        //gia na gemisw to subjectID listbox me ta existing subjects id
        private void FillExistingSubjectsID()
        {
            //TreeNode toMatch;

            //kane clear ola ta items 
            SubjectTreeView.Nodes.Clear();
            //kai gemise me ta subject id
            foreach (var subject in subjects)
            {
                //tsekare an uparxei hdh to subject id
                //an oxi tote kane add
                //toMatch.Tag = subject.GetName();
                //if (!SubjectTreeView.Nodes.Contains(toMatch))
                   // SubjectIDListbox.Items.Add(subject.GetSubjectID());
            }
        }

        //gemise to subject list
        private void FillSubjectList()
        {
            //pare th lista me ta subjects
            //apo to subject
            subjects = SubjectHandler.Subject.GetList();

            //kane sort me vash to Subject ID
            subjects.Sort((x,y) => x.GetSubjectID().CompareTo(y.GetSubjectID()));
        }
        

        //kane add ena kainourio Subject
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SubIDBox.Text) || string.IsNullOrEmpty(RootBox.Text) || string.IsNullOrEmpty(NamBox.Text))
            {
                WarningLabel.Text = "Please enter all fields.";
                WarningLabel.Visible = true;
                return;
            }

            SubjectHandler.SubjectController.AddNewSubject(Int32.Parse(SubIDBox.Text),Int32.Parse(RootBox.Text),NamBox.Text);
            WarningLabel.Visible = false;

            //reload ta subjects poy uparxoun
            SubjectHandler.SubjectController.SearchForExistingSubjects();
            //gemise th lista
            //FillSubjectList();
            //gemise to subject listbox me id
            //FillExistingSubjectsID();
        }
        //kane delete ena subject
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SubIDBox.Text) || string.IsNullOrEmpty(RootBox.Text))
            {
                WarningLabel.Text = "Please enter all fields.";
                WarningLabel.Visible = true;
                return;
            }

            SubjectHandler.SubjectController.DeleteSubject(Int32.Parse(SubIDBox.Text),Int32.Parse(RootBox.Text));
            WarningLabel.Visible = false;

            //reload ta subjects poy uparxoun
            SubjectHandler.SubjectController.SearchForExistingSubjects();
            //gemise th lista
            //FillSubjectList();
            //gemise to subject listbox me id
            //FillExistingSubjectsID();
        }
    }
}
