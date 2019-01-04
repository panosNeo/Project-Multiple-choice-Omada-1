using System;
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

            //gemise to subject listbox me id
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
        
        //gia na gemisw ta components me ta existing subjects
        private void FillExistingSubjectsID()
        {
            //kane clear ola ta items 
            SubjectIDListbox.Items.Clear();
            //kai gemise me ta subject id
            foreach (var subject in subjects)
            {
                SubjectIDListbox.Items.Add(subject.GetSubjectID());
            }

            SubjectIDListbox.SelectedIndex = 0;
        }

        //gemise to subject list
        private void FillSubjectList()
        {
            //pare th lista me ta subjects
            //apo to subjectController
            subjects = SubjectHandler.SubjectController.GetList();

            //kane sort me vash to Subject ID
            subjects.Sort((x,y) => x.GetSubjectID().CompareTo(y.GetSubjectID()));
        }

        //me kathe allagh tou subjectID listbox gemise ta upoloipa components me data
        private void SubjectIDListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var subject in subjects)
            {
                //kane fill ta components sto existing Subject groupBox
                if (subject.GetSubjectID() == SubjectIDListbox.SelectedIndex)
                {
                    RootIDBox.Text = subject.GetRootID().ToString();
                    NameBox.Text = subject.GetName();
                    totalQuizBox.Text = SubjectHandler.SubjectController.QuizzesCounter(subject.GetSubjectID()).ToString();
                }
            }
        }
    }
}
