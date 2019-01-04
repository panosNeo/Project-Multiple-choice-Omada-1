namespace Administrator
{
    partial class SubjectControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExistingSubjectGroup = new System.Windows.Forms.GroupBox();
            this.RootIDListbox = new System.Windows.Forms.ListBox();
            this.totalQuizBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubjectIDListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeSubjectGroup = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NamBox = new System.Windows.Forms.TextBox();
            this.RootBox = new System.Windows.Forms.TextBox();
            this.SubIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalQuestionBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.QuizReset = new System.Windows.Forms.Button();
            this.QuizUpdate = new System.Windows.Forms.Button();
            this.QuizSettingsButton = new System.Windows.Forms.Button();
            this.QuizDelete = new System.Windows.Forms.Button();
            this.QuizAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.QuizIDListbox = new System.Windows.Forms.ListBox();
            this.qDateBox = new System.Windows.Forms.TextBox();
            this.qQuizNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.qUserIDBox = new System.Windows.Forms.TextBox();
            this.qSubIDBox = new System.Windows.Forms.TextBox();
            this.qQuizIDBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExistingSubjectGroup.SuspendLayout();
            this.ChangeSubjectGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExistingSubjectGroup
            // 
            this.ExistingSubjectGroup.Controls.Add(this.RootIDListbox);
            this.ExistingSubjectGroup.Controls.Add(this.totalQuizBox);
            this.ExistingSubjectGroup.Controls.Add(this.NameBox);
            this.ExistingSubjectGroup.Controls.Add(this.label4);
            this.ExistingSubjectGroup.Controls.Add(this.SubjectIDListbox);
            this.ExistingSubjectGroup.Controls.Add(this.label3);
            this.ExistingSubjectGroup.Controls.Add(this.label2);
            this.ExistingSubjectGroup.Controls.Add(this.label1);
            this.ExistingSubjectGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExistingSubjectGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ExistingSubjectGroup.Location = new System.Drawing.Point(20, 19);
            this.ExistingSubjectGroup.Name = "ExistingSubjectGroup";
            this.ExistingSubjectGroup.Size = new System.Drawing.Size(298, 159);
            this.ExistingSubjectGroup.TabIndex = 0;
            this.ExistingSubjectGroup.TabStop = false;
            this.ExistingSubjectGroup.Text = "Existing Subjects";
            // 
            // RootIDListbox
            // 
            this.RootIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RootIDListbox.FormattingEnabled = true;
            this.RootIDListbox.ItemHeight = 17;
            this.RootIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RootIDListbox.Location = new System.Drawing.Point(159, 61);
            this.RootIDListbox.Name = "RootIDListbox";
            this.RootIDListbox.Size = new System.Drawing.Size(83, 21);
            this.RootIDListbox.TabIndex = 5;
            this.RootIDListbox.SelectedIndexChanged += new System.EventHandler(this.RootIDListbox_SelectedIndexChanged);
            // 
            // totalQuizBox
            // 
            this.totalQuizBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalQuizBox.Location = new System.Drawing.Point(159, 117);
            this.totalQuizBox.Name = "totalQuizBox";
            this.totalQuizBox.ReadOnly = true;
            this.totalQuizBox.Size = new System.Drawing.Size(125, 23);
            this.totalQuizBox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameBox.Location = new System.Drawing.Point(159, 88);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(125, 23);
            this.NameBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total of Quizzes :";
            // 
            // SubjectIDListbox
            // 
            this.SubjectIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubjectIDListbox.FormattingEnabled = true;
            this.SubjectIDListbox.ItemHeight = 17;
            this.SubjectIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.SubjectIDListbox.Location = new System.Drawing.Point(159, 32);
            this.SubjectIDListbox.Name = "SubjectIDListbox";
            this.SubjectIDListbox.Size = new System.Drawing.Size(83, 21);
            this.SubjectIDListbox.TabIndex = 0;
            this.SubjectIDListbox.SelectedIndexChanged += new System.EventHandler(this.SubjectIDListbox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Root ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject ID :";
            // 
            // ChangeSubjectGroup
            // 
            this.ChangeSubjectGroup.Controls.Add(this.UpdateButton);
            this.ChangeSubjectGroup.Controls.Add(this.DeleteButton);
            this.ChangeSubjectGroup.Controls.Add(this.AddButton);
            this.ChangeSubjectGroup.Controls.Add(this.NamBox);
            this.ChangeSubjectGroup.Controls.Add(this.RootBox);
            this.ChangeSubjectGroup.Controls.Add(this.SubIDBox);
            this.ChangeSubjectGroup.Controls.Add(this.label6);
            this.ChangeSubjectGroup.Controls.Add(this.label7);
            this.ChangeSubjectGroup.Controls.Add(this.label8);
            this.ChangeSubjectGroup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ChangeSubjectGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ChangeSubjectGroup.Location = new System.Drawing.Point(343, 19);
            this.ChangeSubjectGroup.Name = "ChangeSubjectGroup";
            this.ChangeSubjectGroup.Size = new System.Drawing.Size(373, 159);
            this.ChangeSubjectGroup.TabIndex = 1;
            this.ChangeSubjectGroup.TabStop = false;
            this.ChangeSubjectGroup.Text = "Data Settings";
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(282, 111);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 31);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(282, 74);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 31);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(282, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 31);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NamBox
            // 
            this.NamBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NamBox.Location = new System.Drawing.Point(129, 96);
            this.NamBox.Name = "NamBox";
            this.NamBox.Size = new System.Drawing.Size(125, 23);
            this.NamBox.TabIndex = 2;
            // 
            // RootBox
            // 
            this.RootBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RootBox.Location = new System.Drawing.Point(129, 67);
            this.RootBox.Name = "RootBox";
            this.RootBox.Size = new System.Drawing.Size(125, 23);
            this.RootBox.TabIndex = 1;
            // 
            // SubIDBox
            // 
            this.SubIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SubIDBox.Location = new System.Drawing.Point(129, 38);
            this.SubIDBox.Name = "SubIDBox";
            this.SubIDBox.Size = new System.Drawing.Size(125, 23);
            this.SubIDBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Root ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Subject ID :";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(17, 396);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(38, 16);
            this.WarningLabel.TabIndex = 4;
            this.WarningLabel.Text = "Error";
            this.WarningLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalQuestionBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.QuizReset);
            this.groupBox1.Controls.Add(this.QuizUpdate);
            this.groupBox1.Controls.Add(this.QuizSettingsButton);
            this.groupBox1.Controls.Add(this.QuizDelete);
            this.groupBox1.Controls.Add(this.QuizAdd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.QuizIDListbox);
            this.groupBox1.Controls.Add(this.qDateBox);
            this.groupBox1.Controls.Add(this.qQuizNameBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.qUserIDBox);
            this.groupBox1.Controls.Add(this.qSubIDBox);
            this.groupBox1.Controls.Add(this.qQuizIDBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quizzes";
            // 
            // totalQuestionBox
            // 
            this.totalQuestionBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalQuestionBox.Location = new System.Drawing.Point(387, 120);
            this.totalQuestionBox.Name = "totalQuestionBox";
            this.totalQuestionBox.ReadOnly = true;
            this.totalQuestionBox.Size = new System.Drawing.Size(125, 23);
            this.totalQuestionBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Total of Questions :";
            // 
            // QuizReset
            // 
            this.QuizReset.Enabled = false;
            this.QuizReset.FlatAppearance.BorderSize = 0;
            this.QuizReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizReset.Image = global::Administrator.Properties.Resources.reset;
            this.QuizReset.Location = new System.Drawing.Point(645, 69);
            this.QuizReset.Name = "QuizReset";
            this.QuizReset.Size = new System.Drawing.Size(35, 35);
            this.QuizReset.TabIndex = 9;
            this.QuizReset.UseVisualStyleBackColor = false;
            this.QuizReset.Click += new System.EventHandler(this.QuizReset_Click);
            // 
            // QuizUpdate
            // 
            this.QuizUpdate.Enabled = false;
            this.QuizUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizUpdate.Location = new System.Drawing.Point(564, 106);
            this.QuizUpdate.Name = "QuizUpdate";
            this.QuizUpdate.Size = new System.Drawing.Size(75, 31);
            this.QuizUpdate.TabIndex = 8;
            this.QuizUpdate.Text = "Update";
            this.QuizUpdate.UseVisualStyleBackColor = false;
            // 
            // QuizSettingsButton
            // 
            this.QuizSettingsButton.FlatAppearance.BorderSize = 0;
            this.QuizSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizSettingsButton.Image = global::Administrator.Properties.Resources.settings;
            this.QuizSettingsButton.Location = new System.Drawing.Point(645, 22);
            this.QuizSettingsButton.Name = "QuizSettingsButton";
            this.QuizSettingsButton.Size = new System.Drawing.Size(35, 35);
            this.QuizSettingsButton.TabIndex = 10;
            this.QuizSettingsButton.UseVisualStyleBackColor = false;
            this.QuizSettingsButton.Click += new System.EventHandler(this.QuizSettingsButton_Click);
            // 
            // QuizDelete
            // 
            this.QuizDelete.Enabled = false;
            this.QuizDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizDelete.Location = new System.Drawing.Point(564, 69);
            this.QuizDelete.Name = "QuizDelete";
            this.QuizDelete.Size = new System.Drawing.Size(75, 31);
            this.QuizDelete.TabIndex = 7;
            this.QuizDelete.Text = "Delete";
            this.QuizDelete.UseVisualStyleBackColor = false;
            // 
            // QuizAdd
            // 
            this.QuizAdd.Enabled = false;
            this.QuizAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.QuizAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizAdd.Location = new System.Drawing.Point(564, 32);
            this.QuizAdd.Name = "QuizAdd";
            this.QuizAdd.Size = new System.Drawing.Size(75, 31);
            this.QuizAdd.TabIndex = 6;
            this.QuizAdd.Text = "Add";
            this.QuizAdd.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Existing Quiz ID :";
            // 
            // QuizIDListbox
            // 
            this.QuizIDListbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.QuizIDListbox.FormattingEnabled = true;
            this.QuizIDListbox.ItemHeight = 17;
            this.QuizIDListbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.QuizIDListbox.Location = new System.Drawing.Point(164, 27);
            this.QuizIDListbox.Name = "QuizIDListbox";
            this.QuizIDListbox.Size = new System.Drawing.Size(83, 21);
            this.QuizIDListbox.TabIndex = 0;
            // 
            // qDateBox
            // 
            this.qDateBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qDateBox.Location = new System.Drawing.Point(387, 91);
            this.qDateBox.Name = "qDateBox";
            this.qDateBox.ReadOnly = true;
            this.qDateBox.Size = new System.Drawing.Size(125, 23);
            this.qDateBox.TabIndex = 5;
            // 
            // qQuizNameBox
            // 
            this.qQuizNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuizNameBox.Location = new System.Drawing.Point(387, 62);
            this.qQuizNameBox.Name = "qQuizNameBox";
            this.qQuizNameBox.ReadOnly = true;
            this.qQuizNameBox.Size = new System.Drawing.Size(125, 23);
            this.qQuizNameBox.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Quiz Title :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Creation Date :";
            // 
            // qUserIDBox
            // 
            this.qUserIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qUserIDBox.Location = new System.Drawing.Point(122, 122);
            this.qUserIDBox.Name = "qUserIDBox";
            this.qUserIDBox.ReadOnly = true;
            this.qUserIDBox.Size = new System.Drawing.Size(125, 23);
            this.qUserIDBox.TabIndex = 3;
            // 
            // qSubIDBox
            // 
            this.qSubIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qSubIDBox.Location = new System.Drawing.Point(122, 62);
            this.qSubIDBox.Name = "qSubIDBox";
            this.qSubIDBox.ReadOnly = true;
            this.qSubIDBox.Size = new System.Drawing.Size(125, 23);
            this.qSubIDBox.TabIndex = 1;
            // 
            // qQuizIDBox
            // 
            this.qQuizIDBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.qQuizIDBox.Location = new System.Drawing.Point(122, 92);
            this.qQuizIDBox.Name = "qQuizIDBox";
            this.qQuizIDBox.ReadOnly = true;
            this.qQuizIDBox.Size = new System.Drawing.Size(125, 23);
            this.qQuizIDBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "User ID :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Subject ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quiz ID :";
            // 
            // SubjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(184)))), ((int)(((byte)(185)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeSubjectGroup);
            this.Controls.Add(this.ExistingSubjectGroup);
            this.Controls.Add(this.WarningLabel);
            this.Name = "SubjectControl";
            this.Size = new System.Drawing.Size(736, 423);
            this.Load += new System.EventHandler(this.SubjectControl_Load);
            this.ExistingSubjectGroup.ResumeLayout(false);
            this.ExistingSubjectGroup.PerformLayout();
            this.ChangeSubjectGroup.ResumeLayout(false);
            this.ChangeSubjectGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ExistingSubjectGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SubjectIDListbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalQuizBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.GroupBox ChangeSubjectGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.TextBox SubIDBox;
        private System.Windows.Forms.TextBox NamBox;
        private System.Windows.Forms.TextBox RootBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox qQuizIDBox;
        private System.Windows.Forms.TextBox qUserIDBox;
        private System.Windows.Forms.TextBox qSubIDBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox qDateBox;
        private System.Windows.Forms.TextBox qQuizNameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox QuizIDListbox;
        private System.Windows.Forms.Button QuizDelete;
        private System.Windows.Forms.Button QuizAdd;
        private System.Windows.Forms.Button QuizSettingsButton;
        private System.Windows.Forms.Button QuizUpdate;
        private System.Windows.Forms.Button QuizReset;
        private System.Windows.Forms.TextBox totalQuestionBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox RootIDListbox;
    }
}
