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

        private string existingSubjects = "";
        //gia na dw an allaxe to root id prin apo update
        private int rootID;

        //treeNode gia ta subject Nodes pou exoun childs
        private TreeNode childNode;

        public SubjectControl()
        {
            InitializeComponent();
        }

        private void SubjectControl_Load(object sender, EventArgs e)
        {
            //kane search gia ta subjects pou uparxoun
            SubjectHandler.SubjectController.SearchForExistingSubjects();
            //kane sort th lista
            SubjectHandler.Subject.SortList();
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
            TreeNode node;
            existingSubjects = "";

            //lista me ta root ID pou ekane mia fora elegxo 
            //etsi wste na mhn ta xana kanei
            List<int> ignoreIDs = new List<int>();

            //kane clear ola ta nodes pou uparxoun
            SubjectTreeView.Nodes.Clear();
            //kai gemise nodes me ta subject poy yparxoun
            foreach (var subject in subjects)
            {
                existingSubjects += "Subject ID : " + subject.GetSubjectID() + "\tRoot ID : " + subject.GetRootID() + "\t Subject name : " +subject.GetName() + "\n";
                if (subject.GetRootID() == 0)
                {
                    //an to root ID == 0 tote ftiaxe ta Nodes - kathgories
                    //
                    node = new TreeNode(subject.GetName());
                    node.Name = subject.GetName();
                    node.Tag = subject.GetSubjectID();

                    //kai kane add
                    SubjectHandler.SubjectTreeView.AddRoot(SubjectTreeView,node);
                }
                else
                {
                    int count = -1;
                    List<string> nameList = new List<string>();
                    List<int> subjectIDList = new List<int>();
                    

                    //an den uparxei to root id sto ignore list id's
                    if (!ignoreIDs.Contains(subject.GetRootID())) {
                        //metra ola ta root id pou einai idia kai krata onoma kai subject id
                        foreach (var s in subjects)
                        {
                            if (subject.GetRootID() == s.GetRootID())
                            {
                                nameList.Add(s.GetName());
                                subjectIDList.Add(s.GetSubjectID());
                                count++;
                            }
                        }
                        //kane add to root id sto ignore list gia na to prosperasei sta epomena loop
                        ignoreIDs.Add(subject.GetRootID());
                        
                        //gia kathe Node pou uparxei sto TreeView
                        foreach (TreeNode tNode in SubjectTreeView.Nodes)
                        {   //checkare an to Tag einai root id tou neou Subject
                            //kai an einai, tote ftiaxe ola ta childNodes tou neou subject
                            if (tNode.Tag.Equals(subject.GetRootID()))
                            {   //kane add ta nodes 2 epipedou
                                SubjectHandler.SubjectTreeView.AddNodes(tNode,count,nameList,subjectIDList);
                            }

                            //checkare an yparxoun child nodes 
                            SubjectHandler.SubjectTreeView.SearchChildNodes(tNode,subject.GetRootID());
                            childNode = SubjectHandler.SubjectTreeView.GetChildNode();
                            if (childNode != null)
                            {   //an yparxoun tote kane ta add
                                SubjectHandler.SubjectTreeView.AddNodes(childNode, count, nameList, subjectIDList);
                            }
                            childNode = null; //kane null to child Node gia na deis to epomeno Node an exei paidia
                        }
                    }
                }
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
            FillSubjectList();
            //gemise to subject TreeView me id
            FillExistingSubjectsID();
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
            FillSubjectList();
            //gemise to subject TreeView me id
            FillExistingSubjectsID();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(existingSubjects,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        //otan kanei click se kapoio Node tou treeView
        private void SubjectTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SubIDBox.Text = e.Node.Tag.ToString();

            if (e.Node.Parent != null)
            {
                RootBox.Text = e.Node.Parent.Tag.ToString();
                totalQuizzesBox.Text = SubjectHandler.SubjectController.QuizzesCounter(Int32.Parse(RootBox.Text)).ToString();
                rootID = Int32.Parse(RootBox.Text);
            }
            else
            {
                RootBox.Text = "0";
                totalQuizzesBox.Text = SubjectHandler.SubjectController.QuizzesCounter(Int32.Parse(RootBox.Text)).ToString();
                rootID = Int32.Parse(RootBox.Text);
            }
            NamBox.Text = e.Node.Name;

            SubjectHandler.SubjectTreeView.CheckIfExistNode(e.Node.Parent,Int32.Parse(e.Node.Tag.ToString()));
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int subject_id = Int32.Parse(SubIDBox.Text);
            int root_id = Int32.Parse(RootBox.Text);
            string subject_name = NamBox.Text;
            //an uparxei to root
            if (root_id == rootID)
            {
                SubjectHandler.SubjectController.UpdateSubject(subject_id, root_id, subject_name);
                WarningLabel.Visible = false;
            }
            else if(root_id != rootID && !SubjectHandler.SubjectTreeView.GetCheckIfExist())
            {
                WarningLabel.Text = "The root id does not exist, update failed.";
                WarningLabel.Visible = true;
            }
            //kane search gia ta subjects pou uparxoun
            SubjectHandler.SubjectController.SearchForExistingSubjects();
            //kane sort th lista
            SubjectHandler.Subject.SortList();
            //gemise th lista
            FillSubjectList();
            //gemise to subject treeView me ola ta subjects
            FillExistingSubjectsID();
        }
    }
}
