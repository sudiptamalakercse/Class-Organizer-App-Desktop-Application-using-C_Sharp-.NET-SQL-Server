namespace WindowsFormsApplication1
{
    partial class View_class2_student
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.term = new System.Windows.Forms.ComboBox();
            this.section = new System.Windows.Forms.ComboBox();
            this.viewClasses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.viewClassesStudent = new System.Windows.Forms.DataGridView();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_routineDataSet1 = new WindowsFormsApplication1.class_routineDataSet1();
            this.totalRecords = new System.Windows.Forms.Label();
            this.infoTableAdapter = new WindowsFormsApplication1.class_routineDataSet1TableAdapters.infoTableAdapter();
            this.class_routineDataSet2 = new WindowsFormsApplication1.class_routineDataSet2();
            this.infoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableAdapter1 = new WindowsFormsApplication1.class_routineDataSet2TableAdapters.infoTableAdapter();
            this.sem = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Level : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Term :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(36, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Section  :";
            // 
            // level
            // 
            this.level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.FormattingEnabled = true;
            this.level.Items.AddRange(new object[] {
            "--SELECT--",
            "LEVEL 1",
            "LEVEL 2",
            "LEVEL 3",
            "LEVEL 4"});
            this.level.Location = new System.Drawing.Point(123, 186);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(121, 24);
            this.level.TabIndex = 43;
            // 
            // term
            // 
            this.term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term.FormattingEnabled = true;
            this.term.Items.AddRange(new object[] {
            "--SELECT--",
            "TERM 1",
            "TERM 2",
            "TERM 3"});
            this.term.Location = new System.Drawing.Point(123, 222);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(121, 24);
            this.term.TabIndex = 44;
            // 
            // section
            // 
            this.section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section.FormattingEnabled = true;
            this.section.Items.AddRange(new object[] {
            "--SELECT--",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "R1",
            "R2",
            "R3",
            "R4",
            "R5",
            "R6",
            "R7",
            "R8",
            "R9",
            "R10"});
            this.section.Location = new System.Drawing.Point(123, 150);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(121, 24);
            this.section.TabIndex = 45;
            this.section.SelectedIndexChanged += new System.EventHandler(this.section_SelectedIndexChanged);
            // 
            // viewClasses
            // 
            this.viewClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClasses.Location = new System.Drawing.Point(123, 263);
            this.viewClasses.Margin = new System.Windows.Forms.Padding(4);
            this.viewClasses.Name = "viewClasses";
            this.viewClasses.Size = new System.Drawing.Size(121, 28);
            this.viewClasses.TabIndex = 46;
            this.viewClasses.Text = "View Classes";
            this.viewClasses.UseVisualStyleBackColor = true;
            this.viewClasses.Click += new System.EventHandler(this.viewClasses_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(418, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(522, 73);
            this.label4.TabIndex = 38;
            this.label4.Text = "VIEW CLASSES";
            // 
            // viewClassesStudent
            // 
            this.viewClassesStudent.AllowUserToAddRows = false;
            this.viewClassesStudent.AllowUserToDeleteRows = false;
            this.viewClassesStudent.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewClassesStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewClassesStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewClassesStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weekdayDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.teacherInitialDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn});
            this.viewClassesStudent.DataSource = this.infoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewClassesStudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewClassesStudent.Location = new System.Drawing.Point(260, 149);
            this.viewClassesStudent.Name = "viewClassesStudent";
            this.viewClassesStudent.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewClassesStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewClassesStudent.RowHeadersWidth = 45;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.viewClassesStudent.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewClassesStudent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClassesStudent.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.viewClassesStudent.RowTemplate.Height = 35;
            this.viewClassesStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewClassesStudent.Size = new System.Drawing.Size(1098, 400);
            this.viewClassesStudent.TabIndex = 47;
            this.viewClassesStudent.Tag = "";
            this.viewClassesStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewClassesStudent_CellContentClick);
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.HeaderText = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.Name = "weekdayDataGridViewTextBoxColumn";
            this.weekdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.weekdayDataGridViewTextBoxColumn.Width = 120;
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            this.courseTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseTitleDataGridViewTextBoxColumn.Width = 450;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 80;
            // 
            // startingTimeDataGridViewTextBoxColumn
            // 
            this.startingTimeDataGridViewTextBoxColumn.DataPropertyName = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.HeaderText = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.Name = "startingTimeDataGridViewTextBoxColumn";
            this.startingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endingTimeDataGridViewTextBoxColumn
            // 
            this.endingTimeDataGridViewTextBoxColumn.DataPropertyName = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.HeaderText = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.Name = "endingTimeDataGridViewTextBoxColumn";
            this.endingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherInitialDataGridViewTextBoxColumn
            // 
            this.teacherInitialDataGridViewTextBoxColumn.DataPropertyName = "Teacher_Initial";
            this.teacherInitialDataGridViewTextBoxColumn.FillWeight = 90F;
            this.teacherInitialDataGridViewTextBoxColumn.HeaderText = "Teacher_Initial";
            this.teacherInitialDataGridViewTextBoxColumn.Name = "teacherInitialDataGridViewTextBoxColumn";
            this.teacherInitialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.FillWeight = 90F;
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.class_routineDataSet1;
            // 
            // class_routineDataSet1
            // 
            this.class_routineDataSet1.DataSetName = "class_routineDataSet1";
            this.class_routineDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalRecords
            // 
            this.totalRecords.AutoSize = true;
            this.totalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalRecords.Location = new System.Drawing.Point(255, 561);
            this.totalRecords.Name = "totalRecords";
            this.totalRecords.Size = new System.Drawing.Size(194, 25);
            this.totalRecords.TabIndex = 67;
            this.totalRecords.Tag = "";
            this.totalRecords.Text = "Search Records :";
            this.totalRecords.Click += new System.EventHandler(this.totalRecords_Click);
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // class_routineDataSet2
            // 
            this.class_routineDataSet2.DataSetName = "class_routineDataSet2";
            this.class_routineDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource1
            // 
            this.infoBindingSource1.DataMember = "info";
            this.infoBindingSource1.DataSource = this.class_routineDataSet2;
            // 
            // infoTableAdapter1
            // 
            this.infoTableAdapter1.ClearBeforeFill = true;
            // 
            // sem
            // 
            this.sem.AutoSize = true;
            this.sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sem.Location = new System.Drawing.Point(255, 121);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(132, 25);
            this.sem.TabIndex = 68;
            this.sem.Tag = "";
            this.sem.Text = "Semester  :";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sec.Location = new System.Drawing.Point(1207, 121);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(112, 25);
            this.sec.TabIndex = 69;
            this.sec.Tag = "";
            this.sec.Text = "Section  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(720, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 70;
            this.label3.Tag = "";
            this.label3.Text = "Class Routine";
            // 
            // View_class2_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.totalRecords);
            this.Controls.Add(this.viewClassesStudent);
            this.Controls.Add(this.viewClasses);
            this.Controls.Add(this.section);
            this.Controls.Add(this.term);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Name = "View_class2_student";
            this.Text = "View_class2_student";
            this.Load += new System.EventHandler(this.View_class2_student_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.ComboBox term;
        private System.Windows.Forms.ComboBox section;
        private System.Windows.Forms.Button viewClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView viewClassesStudent;
        private System.Windows.Forms.Label totalRecords;
        private class_routineDataSet1 class_routineDataSet1;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private class_routineDataSet1TableAdapters.infoTableAdapter infoTableAdapter;
        private class_routineDataSet2 class_routineDataSet2;
        private System.Windows.Forms.BindingSource infoBindingSource1;
        private class_routineDataSet2TableAdapters.infoTableAdapter infoTableAdapter1;
        private System.Windows.Forms.Label sem;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;

    }
}