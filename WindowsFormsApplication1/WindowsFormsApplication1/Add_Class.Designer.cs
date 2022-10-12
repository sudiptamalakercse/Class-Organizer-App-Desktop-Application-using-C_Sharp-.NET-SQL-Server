namespace WindowsFormsApplication1
{
    partial class Add_Class
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.program = new System.Windows.Forms.ComboBox();
            this.campus = new System.Windows.Forms.ComboBox();
            this.section = new System.Windows.Forms.TextBox();
            this.courseCode = new System.Windows.Forms.TextBox();
            this.teacherInitial = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.startingTime = new System.Windows.Forms.ComboBox();
            this.endingTime = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.ComboBox();
            this.clearText = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearComboBoxs = new System.Windows.Forms.Button();
            this.saveOrSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addClasses = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class_routineDataSet = new WindowsFormsApplication1.class_routineDataSet();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.searchByCombo = new System.Windows.Forms.ComboBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.Label();
            this.infoTableAdapter = new WindowsFormsApplication1.class_routineDataSetTableAdapters.infoTableAdapter();
            this.totalRecords = new System.Windows.Forms.Label();
            this.saveMode = new System.Windows.Forms.RadioButton();
            this.searchMode = new System.Windows.Forms.RadioButton();
            this.userType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.termCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.levelCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.addClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campus :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(29, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Section :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(29, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Course Code :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(29, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Teacher Initial :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(29, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Weekday :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(28, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Starting Time :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(29, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ending Time :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(29, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Semester :";
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "CSE",
            "SWE"});
            this.department.Location = new System.Drawing.Point(174, 253);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 24);
            this.department.TabIndex = 14;
            this.department.Text = "--SELECT--";
            // 
            // program
            // 
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            "DAY",
            "EVENING"});
            this.program.Location = new System.Drawing.Point(174, 283);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(121, 24);
            this.program.TabIndex = 15;
            this.program.Text = "--SELECT--";
            this.program.SelectedIndexChanged += new System.EventHandler(this.program_SelectedIndexChanged);
            // 
            // campus
            // 
            this.campus.FormattingEnabled = true;
            this.campus.Items.AddRange(new object[] {
            "MAIN",
            "PERMANENT"});
            this.campus.Location = new System.Drawing.Point(174, 313);
            this.campus.Name = "campus";
            this.campus.Size = new System.Drawing.Size(121, 24);
            this.campus.TabIndex = 16;
            this.campus.Text = "--SELECT--";
            // 
            // section
            // 
            this.section.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.section.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.section.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.section.Location = new System.Drawing.Point(174, 489);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(121, 22);
            this.section.TabIndex = 17;
            this.section.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectionDown);
            // 
            // courseCode
            // 
            this.courseCode.AutoCompleteCustomSource.AddRange(new string[] {
            "CSE 112",
            "MAT 111",
            "ENG 113",
            "PHY 113",
            "MAT 121",
            "CSE 122",
            "CSE 123",
            "PHY 123",
            "PHY 124",
            "ENG 123",
            "CSE 131",
            "CSE 132",
            "CSE 133",
            "CSE 134",
            "CSE 135",
            "MAT 131",
            "MAT 211",
            "CSE 212",
            "CSE 213",
            "CSE 214",
            "CSE 215",
            "GED 201",
            "CSE 221",
            "CSE 222",
            "STA 133",
            "CSE 224",
            "CSE 225",
            "CSE 231",
            "CSE 232",
            "CSE 233",
            "CSE 234",
            "CSE 235",
            "CSE 311",
            "CSE 312",
            "CSE 313",
            "CSE 314",
            "GED 321",
            "CSE 321",
            "CSE 322",
            "CSE 323",
            "CSE 324",
            "ECO 314",
            "CSE 331",
            "CSE 332",
            "CSE 333",
            "CSE 334",
            "ACT 301",
            "CSE 412",
            "CSE 413",
            "CSE 414",
            "CSE 415",
            "CSE 417",
            "CSE 418",
            "CSE 421",
            "CSE 422",
            "CSE 423",
            "CSE 450",
            "CSE 499",
            "CSE 433",
            "CSE 498",
            "CSE 499",
            "CSE 333",
            "CSE 432",
            "CSE 499",
            "CSE 411",
            "CSE 412",
            "CSE 412 L",
            "CSE 332",
            "CSE 499",
            "CSE 321",
            "CSE 321 L",
            "CSE 421",
            "CSE 421 L",
            "CSE 431",
            "MGT 414",
            "CSE 331",
            "CSE 331 L",
            "CSE 413",
            "CSE 413 L",
            "CSE 323",
            "CSE 323 L",
            "CSE 322",
            "CSE 313",
            "CSE 313 L",
            "CSE 311",
            "CSE 311 L",
            "CSE 312",
            "CSE 231",
            "CSE 231 L",
            "CSE 224",
            "CSE 224 L",
            "CSE 232",
            "CSE 233",
            "CSE 221",
            "CSE 222",
            "CSE 222 L",
            "MAT 211",
            "MAT 223",
            "CSE 213",
            "CSE 213 L",
            "ACC 214",
            "ECO 314",
            "MAT 134",
            "MAT 121",
            "CSE 131",
            "ENG 113",
            "PHY 123",
            "PHY 123 L"});
            this.courseCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.courseCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.courseCode.Location = new System.Drawing.Point(174, 461);
            this.courseCode.Name = "courseCode";
            this.courseCode.Size = new System.Drawing.Size(121, 22);
            this.courseCode.TabIndex = 20;
            this.courseCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.courseCodeDown);
            // 
            // teacherInitial
            // 
            this.teacherInitial.AutoCompleteCustomSource.AddRange(new string[] {
            "AA",
            "AA-C",
            "AAH",
            "AAK",
            "AAM",
            "AAN",
            "AAR",
            "AC",
            "AH",
            "AHN",
            "AI",
            "AKMM",
            "AM",
            "ANM",
            "AR",
            "ASMFH",
            "AST",
            "ATM",
            "ATP",
            "AUZA",
            "BA",
            "BCD",
            "DG",
            "DKMR",
            "DMM",
            "DMR",
            "DR",
            "EA",
            "EK",
            "EKM",
            "EUH",
            "FA",
            "FBA",
            "FF",
            "FH",
            "FHS",
            "FI",
            "FI-C",
            "FK",
            "FM",
            "FNN",
            "FS",
            "FSN",
            "FY",
            "GZI",
            "HH",
            "IF",
            "IH",
            "IK",
            "ILH",
            "IN",
            "JNS",
            "KEH",
            "KFP",
            "LR",
            "MAH",
            "MAN",
            "MAR",
            "MAS",
            "MBS",
            "MDG",
            "MDN",
            "MEF",
            "MFA",
            "MFC",
            "MFH",
            "MH",
            "MHK",
            "MHN",
            "MHZ",
            "MIH",
            "MIHN",
            "MJA",
            "MJM",
            "MJU",
            "MKH",
            "MM",
            "MMH",
            "MMI-C",
            "MMM",
            "MMR-C",
            "MMRN",
            "MNR",
            "MPL",
            "MR",
            "MRA",
            "MRH",
            "MRN",
            "MSA",
            "MSB",
            "MSF",
            "MTH",
            "MTM",
            "MZB",
            "NIS",
            "NJ",
            "NN",
            "NNM",
            "NR",
            "NR-M",
            "NRC",
            "NS",
            "NS-M",
            "NSA",
            "PD",
            "RAH",
            "RAM",
            "RH",
            "RIM",
            "RR",
            "RS",
            "RUH",
            "SA",
            "SAB",
            "SAH",
            "SAN",
            "SAR",
            "SAS",
            "SB",
            "SBS",
            "SD",
            "SDB",
            "SF",
            "SHK",
            "SI",
            "SK",
            "SKB",
            "SKR",
            "SM",
            "SMA",
            "SMR",
            "SMS",
            "SMTS",
            "SN",
            "SNP",
            "SP",
            "SR",
            "SRH",
            "SRS",
            "SS",
            "SSK",
            "ST",
            "STA",
            "SZ",
            "SZN",
            "TA",
            "TB",
            "THT",
            "TIR",
            "TM",
            "TRA",
            "UD",
            "UH",
            "WRB",
            "YP",
            "ZH",
            "ZNT",
            "ZZ",
            "AA",
            "AA-C",
            "AAK",
            "AAN",
            "AAR",
            "ACC",
            "AHN",
            "AIO",
            "AKA",
            "AM",
            "ASMFH",
            "ATP",
            "AUZA",
            "DMM",
            "DMR",
            "EA",
            "EK",
            "FBA",
            "FH",
            "FI-C",
            "FSN",
            "GZI",
            "IK",
            "ILH",
            "LR",
            "MAH",
            "MAHN",
            "MAS",
            "MB",
            "MBS",
            "MDG",
            "MDN",
            "MEF",
            "MFC",
            "MIB",
            "MJM",
            "MJU",
            "ML",
            "MM",
            "MMH",
            "MMR",
            "MMR-C",
            "MSH",
            "MTO",
            "NIS",
            "NNM",
            "NS",
            "RR",
            "RT",
            "SAB",
            "SAR",
            "SB",
            "SD",
            "SDB",
            "SHK",
            "SJS",
            "SK",
            "SKB",
            "SZ",
            "TA",
            "TB",
            "TBA",
            "TRA",
            "UD",
            "UH",
            "YP",
            "ZNT"});
            this.teacherInitial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teacherInitial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.teacherInitial.Location = new System.Drawing.Point(174, 517);
            this.teacherInitial.Name = "teacherInitial";
            this.teacherInitial.Size = new System.Drawing.Size(121, 22);
            this.teacherInitial.TabIndex = 22;
            this.teacherInitial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teacherInitialDown);
            // 
            // weekday
            // 
            this.weekday.FormattingEnabled = true;
            this.weekday.Items.AddRange(new object[] {
            "SATURDAY",
            "SUNDAY",
            "MONDAY",
            "TUESDAY",
            "WEDNESDAY",
            "THURSDAY",
            "FRIDAY"});
            this.weekday.Location = new System.Drawing.Point(174, 343);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(121, 24);
            this.weekday.TabIndex = 23;
            this.weekday.Text = "--SELECT--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(29, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Room :";
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(174, 433);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(121, 22);
            this.room.TabIndex = 25;
            this.room.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomDown);
            // 
            // startingTime
            // 
            this.startingTime.FormattingEnabled = true;
            this.startingTime.Items.AddRange(new object[] {
            "08:30 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "11:30 AM ",
            "01:00 PM",
            "02:30 PM",
            "03:00 PM",
            "04:00 PM",
            "06:00 PM",
            "07:30 PM",
            "09:00 PM"});
            this.startingTime.Location = new System.Drawing.Point(174, 373);
            this.startingTime.Name = "startingTime";
            this.startingTime.Size = new System.Drawing.Size(121, 24);
            this.startingTime.TabIndex = 26;
            this.startingTime.Text = "--SELECT--";
            // 
            // endingTime
            // 
            this.endingTime.FormattingEnabled = true;
            this.endingTime.Items.AddRange(new object[] {
            "10:00 AM",
            "11:00 AM",
            "11:30 AM",
            "01:00 PM",
            "02:30 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "07:30 PM",
            "09:00 PM",
            "12:00 AM"});
            this.endingTime.Location = new System.Drawing.Point(174, 403);
            this.endingTime.Name = "endingTime";
            this.endingTime.Size = new System.Drawing.Size(121, 24);
            this.endingTime.TabIndex = 27;
            this.endingTime.Text = "--SELECT--";
            // 
            // semester
            // 
            this.semester.FormattingEnabled = true;
            this.semester.Items.AddRange(new object[] {
            "FALL 2018",
            "SPRING 2019",
            "SUMMER 2019",
            "FALL 2019",
            "SPRING 2020",
            "SUMMER 2020",
            "FALL 2020"});
            this.semester.Location = new System.Drawing.Point(174, 223);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(121, 24);
            this.semester.TabIndex = 28;
            this.semester.Text = "--SELECT--";
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(173, 581);
            this.clearText.Margin = new System.Windows.Forms.Padding(4);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(135, 28);
            this.clearText.TabIndex = 29;
            this.clearText.Text = "Clear Text Fields";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(100, 616);
            this.clearAll.Margin = new System.Windows.Forms.Padding(4);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(136, 28);
            this.clearAll.TabIndex = 30;
            this.clearAll.Text = "Clear All Fields";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // clearComboBoxs
            // 
            this.clearComboBoxs.Location = new System.Drawing.Point(16, 581);
            this.clearComboBoxs.Margin = new System.Windows.Forms.Padding(4);
            this.clearComboBoxs.Name = "clearComboBoxs";
            this.clearComboBoxs.Size = new System.Drawing.Size(149, 28);
            this.clearComboBoxs.TabIndex = 31;
            this.clearComboBoxs.Text = "Clear Select Boxes";
            this.clearComboBoxs.UseVisualStyleBackColor = true;
            this.clearComboBoxs.Click += new System.EventHandler(this.clearComboBoxs_Click);
            // 
            // saveOrSearch
            // 
            this.saveOrSearch.Location = new System.Drawing.Point(173, 546);
            this.saveOrSearch.Margin = new System.Windows.Forms.Padding(4);
            this.saveOrSearch.Name = "saveOrSearch";
            this.saveOrSearch.Size = new System.Drawing.Size(135, 28);
            this.saveOrSearch.TabIndex = 32;
            this.saveOrSearch.Text = "Save Or Search";
            this.saveOrSearch.UseVisualStyleBackColor = true;
            this.saveOrSearch.Click += new System.EventHandler(this.saveOrSearchClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(470, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 73);
            this.label5.TabIndex = 33;
            this.label5.Text = "ADD CLASSES";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addClasses
            // 
            this.addClasses.AllowUserToAddRows = false;
            this.addClasses.AllowUserToDeleteRows = false;
            this.addClasses.AutoGenerateColumns = false;
            this.addClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.campusDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.teacherInitialDataGridViewTextBoxColumn,
            this.weekdayDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.addClasses.DataSource = this.infoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addClasses.DefaultCellStyle = dataGridViewCellStyle1;
            this.addClasses.Location = new System.Drawing.Point(321, 133);
            this.addClasses.Name = "addClasses";
            this.addClasses.ReadOnly = true;
            this.addClasses.RowTemplate.Height = 35;
            this.addClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addClasses.Size = new System.Drawing.Size(1022, 386);
            this.addClasses.TabIndex = 57;
            this.addClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addClasses_CellContentClick);
            this.addClasses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addClasses_MouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campusDataGridViewTextBoxColumn
            // 
            this.campusDataGridViewTextBoxColumn.DataPropertyName = "Campus";
            this.campusDataGridViewTextBoxColumn.HeaderText = "Campus";
            this.campusDataGridViewTextBoxColumn.Name = "campusDataGridViewTextBoxColumn";
            this.campusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "Course_Code";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            this.courseTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseTitleDataGridViewTextBoxColumn.Width = 450;
            // 
            // teacherInitialDataGridViewTextBoxColumn
            // 
            this.teacherInitialDataGridViewTextBoxColumn.DataPropertyName = "Teacher_Initial";
            this.teacherInitialDataGridViewTextBoxColumn.HeaderText = "Teacher_Initial";
            this.teacherInitialDataGridViewTextBoxColumn.Name = "teacherInitialDataGridViewTextBoxColumn";
            this.teacherInitialDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherInitialDataGridViewTextBoxColumn.Width = 150;
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.HeaderText = "Weekday";
            this.weekdayDataGridViewTextBoxColumn.Name = "weekdayDataGridViewTextBoxColumn";
            this.weekdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startingTimeDataGridViewTextBoxColumn
            // 
            this.startingTimeDataGridViewTextBoxColumn.DataPropertyName = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.HeaderText = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.Name = "startingTimeDataGridViewTextBoxColumn";
            this.startingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startingTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // endingTimeDataGridViewTextBoxColumn
            // 
            this.endingTimeDataGridViewTextBoxColumn.DataPropertyName = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.HeaderText = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.Name = "endingTimeDataGridViewTextBoxColumn";
            this.endingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endingTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterDataGridViewTextBoxColumn.Width = 150;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.class_routineDataSet;
            // 
            // class_routineDataSet
            // 
            this.class_routineDataSet.DataSetName = "class_routineDataSet";
            this.class_routineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(321, 546);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(122, 28);
            this.update.TabIndex = 58;
            this.update.Text = "Update Record";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(451, 547);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(121, 28);
            this.delete.TabIndex = 60;
            this.delete.Text = "Delete Record";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // searchByCombo
            // 
            this.searchByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCombo.FormattingEnabled = true;
            this.searchByCombo.Items.AddRange(new object[] {
            "----------SELECT----------",
            "ID",
            "LEVEL",
            "TERM",
            "SEMESTER",
            "DEPARTMENT",
            "PROGRAM",
            "CAMPUS",
            "WEEK DAY",
            "STARTING TIME",
            "ENDING TIME",
            "ROOM",
            "COURSE CODE",
            "COURSE TITLE",
            "SECTION",
            "TEACHER INITIAL",
            "",
            "",
            ""});
            this.searchByCombo.Location = new System.Drawing.Point(460, 620);
            this.searchByCombo.Name = "searchByCombo";
            this.searchByCombo.Size = new System.Drawing.Size(174, 24);
            this.searchByCombo.TabIndex = 61;
            this.searchByCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(580, 547);
            this.deleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(147, 28);
            this.deleteAll.TabIndex = 63;
            this.deleteAll.Text = "Delete All Records";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(381, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Search :";
            // 
            // searchBy
            // 
            this.searchBy.AutoSize = true;
            this.searchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBy.Location = new System.Drawing.Point(353, 624);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(101, 20);
            this.searchBy.TabIndex = 65;
            this.searchBy.Text = "Search By :";
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // totalRecords
            // 
            this.totalRecords.AutoSize = true;
            this.totalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalRecords.Location = new System.Drawing.Point(944, 548);
            this.totalRecords.Name = "totalRecords";
            this.totalRecords.Size = new System.Drawing.Size(159, 25);
            this.totalRecords.TabIndex = 66;
            this.totalRecords.Text = "Total Records";
            // 
            // saveMode
            // 
            this.saveMode.AutoSize = true;
            this.saveMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveMode.Location = new System.Drawing.Point(34, 103);
            this.saveMode.Name = "saveMode";
            this.saveMode.Size = new System.Drawing.Size(110, 22);
            this.saveMode.TabIndex = 67;
            this.saveMode.TabStop = true;
            this.saveMode.Text = "Save Mode";
            this.saveMode.UseVisualStyleBackColor = true;
            this.saveMode.CheckedChanged += new System.EventHandler(this.saveMode_CheckedChanged);
            // 
            // searchMode
            // 
            this.searchMode.AutoSize = true;
            this.searchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchMode.Location = new System.Drawing.Point(175, 105);
            this.searchMode.Name = "searchMode";
            this.searchMode.Size = new System.Drawing.Size(126, 22);
            this.searchMode.TabIndex = 68;
            this.searchMode.TabStop = true;
            this.searchMode.Text = "Search Mode";
            this.searchMode.UseVisualStyleBackColor = true;
            this.searchMode.CheckedChanged += new System.EventHandler(this.searchMode_CheckedChanged);
            // 
            // userType
            // 
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "STUDENT",
            "TEACHER"});
            this.userType.Location = new System.Drawing.Point(174, 133);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(121, 24);
            this.userType.TabIndex = 70;
            this.userType.Text = "--SELECT--";
            this.userType.SelectedIndexChanged += new System.EventHandler(this.userType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(30, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "User Type :";
            // 
            // search
            // 
            this.search.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search.Location = new System.Drawing.Point(460, 587);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(174, 22);
            this.search.TabIndex = 75;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged_1);
            // 
            // termCombo
            // 
            this.termCombo.FormattingEnabled = true;
            this.termCombo.Items.AddRange(new object[] {
            "TERM 1",
            "TERM 2",
            "TERM 3"});
            this.termCombo.Location = new System.Drawing.Point(174, 193);
            this.termCombo.Name = "termCombo";
            this.termCombo.Size = new System.Drawing.Size(121, 24);
            this.termCombo.TabIndex = 72;
            this.termCombo.Text = "--SELECT--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(30, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = "Term :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(30, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = "Level :";
            // 
            // levelCombo
            // 
            this.levelCombo.FormattingEnabled = true;
            this.levelCombo.Items.AddRange(new object[] {
            "LEVEL 1",
            "LEVEL 2",
            "LEVEL 3",
            "LEVEL 4"});
            this.levelCombo.Location = new System.Drawing.Point(175, 163);
            this.levelCombo.Name = "levelCombo";
            this.levelCombo.Size = new System.Drawing.Size(121, 24);
            this.levelCombo.TabIndex = 71;
            this.levelCombo.Text = "--SELECT--";
            // 
            // Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.termCombo);
            this.Controls.Add(this.levelCombo);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchMode);
            this.Controls.Add(this.saveMode);
            this.Controls.Add(this.totalRecords);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.searchByCombo);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addClasses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveOrSearch);
            this.Controls.Add(this.clearComboBoxs);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.endingTime);
            this.Controls.Add(this.startingTime);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.teacherInitial);
            this.Controls.Add(this.courseCode);
            this.Controls.Add(this.section);
            this.Controls.Add(this.campus);
            this.Controls.Add(this.program);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Class";
            this.Text = " Add_Class";
            this.Load += new System.EventHandler(this.Add_Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_routineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox program;
        private System.Windows.Forms.ComboBox campus;
        private System.Windows.Forms.TextBox section;
        private System.Windows.Forms.TextBox courseCode;
        private System.Windows.Forms.TextBox teacherInitial;
        private System.Windows.Forms.ComboBox weekday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox room;
        private System.Windows.Forms.ComboBox startingTime;
        private System.Windows.Forms.ComboBox endingTime;
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearComboBoxs;
        private System.Windows.Forms.Button saveOrSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView addClasses;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox searchByCombo;
       
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label searchBy;
        private class_routineDataSet class_routineDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private class_routineDataSetTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label totalRecords;
        private System.Windows.Forms.RadioButton saveMode;
        private System.Windows.Forms.RadioButton searchMode;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox termCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox levelCombo;
    }
}