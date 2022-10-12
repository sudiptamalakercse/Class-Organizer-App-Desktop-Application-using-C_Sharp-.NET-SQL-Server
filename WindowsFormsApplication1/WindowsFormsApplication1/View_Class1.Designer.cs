namespace WindowsFormsApplication1
{
    partial class View_Class1
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
            this.button1 = new System.Windows.Forms.Button();
            this.semester = new System.Windows.Forms.ComboBox();
            this.campus = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // semester
            // 
            this.semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "--SELECT--",
            "FALL 2018",
            "SPRING 2019",
            "SUMMER 2019",
            "FALL 2019",
            "SPRING 2020",
            "SUMMER 2020",
            "FALL 2020"});
            this.semester.Location = new System.Drawing.Point(713, 162);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(121, 24);
            this.semester.TabIndex = 36;
            this.semester.SelectedIndexChanged += new System.EventHandler(this.semester_SelectedIndexChanged);
            // 
            // campus
            // 
            this.campus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campus.FormattingEnabled = true;
            this.campus.Items.AddRange(new object[] {
            "--SELECT--",
            "MAIN",
            "PERMANENT"});
            this.campus.Location = new System.Drawing.Point(713, 281);
            this.campus.Name = "campus";
            this.campus.Size = new System.Drawing.Size(121, 24);
            this.campus.TabIndex = 35;
            this.campus.SelectedIndexChanged += new System.EventHandler(this.campus_SelectedIndexChanged);
            // 
            // department
            // 
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "--SELECT--",
            "CSE",
            "SWE"});
            this.department.Location = new System.Drawing.Point(713, 203);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 24);
            this.department.TabIndex = 33;
            this.department.SelectedIndexChanged += new System.EventHandler(this.department_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(568, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Semester :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(568, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Campus :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(568, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Department : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(438, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(528, 78);
            this.label4.TabIndex = 37;
            this.label4.Text = "VIEW CLASSES";
            // 
            // userType
            // 
            this.userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "--SELECT--",
            "STUDENT",
            "TEACHER"});
            this.userType.Location = new System.Drawing.Point(713, 122);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(121, 24);
            this.userType.TabIndex = 39;
            this.userType.SelectedIndexChanged += new System.EventHandler(this.userType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(568, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "User Type :";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(713, 322);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(121, 28);
            this.next.TabIndex = 40;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // program
            // 
            this.program.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            "--SELECT--",
            "DAY",
            "EVENING"});
            this.program.Location = new System.Drawing.Point(713, 242);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(121, 24);
            this.program.TabIndex = 42;
            this.program.SelectedIndexChanged += new System.EventHandler(this.program_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(568, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Program :";
            // 
            // View_Class1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.program);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.campus);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Class1";
            this.Text = "Campus";
            this.Load += new System.EventHandler(this.View_Class_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.View_Class1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.ComboBox campus;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.Label label2;
    }
}