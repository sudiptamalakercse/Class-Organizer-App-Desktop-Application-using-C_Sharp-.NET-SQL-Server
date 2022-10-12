namespace WindowsFormsApplication1
{
    partial class View_class3_teacher
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
            this.label4 = new System.Windows.Forms.Label();
            this.viewClassesTeaccher = new System.Windows.Forms.DataGridView();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_routineDataSet3 = new WindowsFormsApplication1.class_routineDataSet3();
            this.viewClasses = new System.Windows.Forms.Button();
            this.teacherInitial = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.totalRecords = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.initial = new System.Windows.Forms.Label();
            this.infoTableAdapter = new WindowsFormsApplication1.class_routineDataSet3TableAdapters.infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesTeaccher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(409, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(522, 73);
            this.label4.TabIndex = 39;
            this.label4.Text = "VIEW CLASSES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // viewClassesTeaccher
            // 
            this.viewClassesTeaccher.AllowUserToAddRows = false;
            this.viewClassesTeaccher.AllowUserToDeleteRows = false;
            this.viewClassesTeaccher.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewClassesTeaccher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewClassesTeaccher.ColumnHeadersHeight = 29;
            this.viewClassesTeaccher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weekdayDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn});
            this.viewClassesTeaccher.DataSource = this.infoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewClassesTeaccher.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewClassesTeaccher.Location = new System.Drawing.Point(279, 179);
            this.viewClassesTeaccher.Name = "viewClassesTeaccher";
            this.viewClassesTeaccher.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewClassesTeaccher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewClassesTeaccher.RowHeadersWidth = 45;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.viewClassesTeaccher.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewClassesTeaccher.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClassesTeaccher.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.viewClassesTeaccher.RowTemplate.Height = 35;
            this.viewClassesTeaccher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewClassesTeaccher.Size = new System.Drawing.Size(1048, 394);
            this.viewClassesTeaccher.TabIndex = 47;
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.FillWeight = 120F;
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
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionDataGridViewTextBoxColumn.Width = 60;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.class_routineDataSet3;
            // 
            // class_routineDataSet3
            // 
            this.class_routineDataSet3.DataSetName = "class_routineDataSet3";
            this.class_routineDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClasses
            // 
            this.viewClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewClasses.Location = new System.Drawing.Point(151, 221);
            this.viewClasses.Margin = new System.Windows.Forms.Padding(4);
            this.viewClasses.Name = "viewClasses";
            this.viewClasses.Size = new System.Drawing.Size(111, 28);
            this.viewClasses.TabIndex = 55;
            this.viewClasses.Text = "View Classes";
            this.viewClasses.UseVisualStyleBackColor = true;
            this.viewClasses.Click += new System.EventHandler(this.viewClasses_Click);
            // 
            // teacherInitial
            // 
            this.teacherInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherInitial.FormattingEnabled = true;
            this.teacherInitial.Location = new System.Drawing.Point(151, 181);
            this.teacherInitial.Name = "teacherInitial";
            this.teacherInitial.Size = new System.Drawing.Size(111, 24);
            this.teacherInitial.TabIndex = 54;
            this.teacherInitial.SelectedIndexChanged += new System.EventHandler(this.teacherInitial_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(12, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Teacher Initial :";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(16, 221);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(111, 28);
            this.back.TabIndex = 48;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // totalRecords
            // 
            this.totalRecords.AutoSize = true;
            this.totalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalRecords.Location = new System.Drawing.Point(274, 576);
            this.totalRecords.Name = "totalRecords";
            this.totalRecords.Size = new System.Drawing.Size(194, 25);
            this.totalRecords.TabIndex = 68;
            this.totalRecords.Tag = "";
            this.totalRecords.Text = "Search Records :";
            this.totalRecords.Click += new System.EventHandler(this.totalRecords_Click);
            // 
            // sem
            // 
            this.sem.AutoSize = true;
            this.sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sem.Location = new System.Drawing.Point(274, 151);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(132, 25);
            this.sem.TabIndex = 69;
            this.sem.Tag = "";
            this.sem.Text = "Semester  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(726, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 71;
            this.label3.Tag = "";
            this.label3.Text = "Class Routine";
            // 
            // initial
            // 
            this.initial.AutoSize = true;
            this.initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.initial.Location = new System.Drawing.Point(1038, 151);
            this.initial.Name = "initial";
            this.initial.Size = new System.Drawing.Size(183, 25);
            this.initial.TabIndex = 72;
            this.initial.Tag = "";
            this.initial.Text = "Teacher Initial  :";
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // View_class3_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.initial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.totalRecords);
            this.Controls.Add(this.viewClassesTeaccher);
            this.Controls.Add(this.viewClasses);
            this.Controls.Add(this.teacherInitial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Name = "View_class3_teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View_class3_teacher";
            this.Load += new System.EventHandler(this.View_class3_teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesTeaccher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView viewClassesTeaccher;
        private System.Windows.Forms.Button viewClasses;
        private System.Windows.Forms.ComboBox teacherInitial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label totalRecords;
        private System.Windows.Forms.Label sem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label initial;
        private class_routineDataSet3 class_routineDataSet3;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private class_routineDataSet3TableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
    }
}