using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class View_class3_teacher : Form
    {
        private int countRecord;
         Class_Organizer b = new Class_Organizer();
           
        public View_class3_teacher()
        {
            InitializeComponent();

            
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            b.beepSound();
            this.Hide();
            View_class2_student v = new View_class2_student();
            v.vewClass1();
        }

  

        private void back_Click(object sender, EventArgs e)
        {
            b.beepSound();
            this.Hide();
            View_class2_student v = new View_class2_student();
            v.vewClass1();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SC073EN;Initial Catalog=class_routine;Integrated Security=True");
        private void viewClasses_Click(object sender, EventArgs e)
        {

            View_Class1 vc = new View_Class1();
            string semester = vc.get_semester();
            string department = vc.get_department();
            string program = vc.get_program();
            string campus = vc.get_campus();
            b.beepSound();
            if ((teacherInitial.Text != "--SELECT--"))
            {
              //  MessageBox.Show("Working Well");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Weekday,Course_Title,Room,Starting_Time,Ending_Time,Section,Course_Code from info where Department = '" + department + "' and Program = '" + program + "' and Campus = '" + campus + "' and Semester = '" + semester + "' and Teacher_Initial = '" + teacherInitial.Text + "' order by ID", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                viewClassesTeaccher.DataSource = data;

                //  viewClassesStudent.Sort(viewClassesStudent.Columns[0], ListSortDirection.Ascending);
                DataGridView dataGridviewName = viewClassesTeaccher;
                dataGridviewDesign(dataGridviewName);


                con.Close();
                //count recors
                countRecord = viewClassesTeaccher.Rows.Count;
                totalRecords.Text = "Search Records : " + countRecord.ToString();
                sem.Text = "Semester : " + semester + " (" + program + ")";
                initial.Text = "Teacher Initial : " + teacherInitial.Text;
                if (countRecord == 0)
                {
                    MessageBox.Show("No Information Was Found In The Search");
                }
            }
            else
            {
                MessageBox.Show("Select Teacher Initial");
            }
        }

        private void dataGridviewDesign(DataGridView dataGridviewName)
        {

            dataGridviewName.BorderStyle = BorderStyle.None;
            dataGridviewName.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridviewName.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridviewName.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridviewName.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridviewName.BackgroundColor = Color.White;

            dataGridviewName.EnableHeadersVisualStyles = false;
            dataGridviewName.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridviewName.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridviewName.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void teacherInitial_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

     

    public void View_class3_teacher_Load(object sender, EventArgs e)
        {
           
        
             View_Class1 vc1 = new View_Class1();
             string getProgram = vc1.get_program();


             if (getProgram =="DAY")
            {
                teacherInitial.Items.AddRange(new object[] { 
                    "--SELECT--","AA", "AA-C", "AAH", "AAK", "AAM", "AAN", "AAR", "AC","AH", "AHN",
                    "AI", "AKMM", "AM", "ANM", "AR", "ASMFH", "AST", "ATM","ATP", "AUZA",
                    "BA", "BCD", "DG", "DKMR", "DMM", "DMR", "DR", "EA","EK", "EKM",
                    "EUH", "FA", "FBA", "FF", "FH", "FHS", "FI", "FI-C","FK", "FM",
                    "FNN", "FS", "FSN", "FY", "GZI", "HH", "IF", "IH","IK", "ILH",
                    "IN", "JNS", "KEH", "KFP", "LR", "MAH", "MAN", "MAR","MAS", "MBS",
                    "MDG", "MDN", "MEF", "MFA", "MFC", "MFH", "MH", "MHK","MHN", "MHZ",
                    "MIH", "MIHN", "MJA", "MJM", "MJU", "MKH", "MM", "MMH","MMI-C", "MMM",
                    "MMR-C", "MMRN", "MNR", "MPL", "MR", "MRA", "MRH", "MRN","MSA", "MSB",
                    "MSF", "MTH", "MTM", "MZB", "NIS", "NJ", "NN", "NNM","NR", "NR-M",
                    "NRC", "NS", "NS-M", "NSA", "PD", "RAH", "RAM", "RH","RIM", "RR",
                    "RS", "RUH", "SA", "SAB", "SAH", "SAN", "SAR", "SAS","SB", "SBS",
                    "SD", "SDB", "SF", "SHK", "SI", "SK", "SKB", "SKR","SM", "SMA",
                    "SMR", "SMS", "SMTS", "SN", "SNP", "SP", "SR", "SRH","SRS", "SS",
                    "SSK", "ST", "STA", "SZ", "SZN", "TA", "TB", "THT","TIR", "TM",
                    "TRA", "UD", "UH", "WRB", "YP", "ZH", "ZNT", "ZZ"});
             
             
            }
             else if (getProgram =="EVENING")
            {
                teacherInitial.Items.AddRange(new object[] { 
                    "--SELECT--","AA", "AA-C", "AAK", "AAN", "AAR", "ACC", "AHN", "AIO", "AKA", "AM",
                    "ASMFH", "ATP", "AUZA", "DMM", "DMR", "EA", "EK", "FBA", "FH", "FI-C", 
                    "FSN", "GZI", "IK", "ILH", "LR", "MAH", "MAHN", "MAS", "MB", "MBS",
                    "MDG", "MDN", "MEF", "MFC", "MIB", "MJM", "MJU", "ML", "MM", "MMH",
                    "MMR", "MMR-C", "MSH", "MTO", "NIS", "NNM", "NS", "RR", "RT", "SAB",
                    "SAR", "SB", "SD", "SDB", "SHK", "SJS", "SK", "SKB", "SZ", "TA",
                    "TB", "TBA", "TRA", "UD", "UH", "YP", "ZNT"});
              
            
            }

             teacherInitial.Sorted=true;
             teacherInitial.SelectedIndex = 0;
            
            
        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void totalRecords_Click(object sender, EventArgs e)
    {

    }
    }
}
