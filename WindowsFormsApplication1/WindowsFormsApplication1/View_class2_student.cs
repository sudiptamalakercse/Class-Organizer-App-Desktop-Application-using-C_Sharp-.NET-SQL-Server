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
    public partial class View_class2_student : Form
    {
        private int countRecord;
         Class_Organizer b = new Class_Organizer();
         
           
        public View_class2_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.beepSound();
            this.Hide();
            vewClass1();
        }

     public  void vewClass1()
        {
            View_Class1 vie = new View_Class1();
            vie.Show();
        }




     SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SC073EN;Initial Catalog=class_routine;Integrated Security=True");
    public void viewClasses_Click_1(object sender, EventArgs e)
     {
         View_Class1 vc = new View_Class1();
         string semester = vc.get_semester();
         string department = vc.get_department();
         string program = vc.get_program();
         string campus = vc.get_campus();
   
         
         b.beepSound();
         if ((section.Text != "--SELECT--") && (level.Text != "--SELECT--") && (term.Text != "--SELECT--"))
         {
            
           //  MessageBox.Show("Working Well");
             con.Open();
             SqlDataAdapter sda = new SqlDataAdapter("select Weekday,Course_Title,Room,Starting_Time,Ending_Time,Teacher_Initial,Course_Code from info where Department = '" + department + "' and Program = '" + program + "' and Campus = '" + campus + "' and Semester = '" + semester + "' and Section = '" + section.Text + "' and Label = '" + level.Text + "'and Term = '" + term.Text + "' order by ID", con);
             DataTable data = new DataTable();
              sda.Fill(data);
             viewClassesStudent.DataSource = data;

           //  viewClassesStudent.Sort(viewClassesStudent.Columns[0], ListSortDirection.Ascending);
             DataGridView dataGridviewName = viewClassesStudent;
             dataGridviewDesign(dataGridviewName);


             con.Close();
             //count recors
             countRecord = viewClassesStudent.Rows.Count;
             totalRecords.Text = "Search Records : " + countRecord.ToString();
             sem.Text = "Semester : " + semester + " (" + program + ")";
             sec.Text = "Section : " + section.Text;
             if (countRecord==0)
             {
             MessageBox.Show("No Information Was Found In The Search");
             }

            
         }
         else
         {
             MessageBox.Show("Select All Options");
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
     private void section_SelectedIndexChanged(object sender, EventArgs e)
     {

     }

     private void button2_Click(object sender, EventArgs e)
     {

     }

     private void viewClassesStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
     {

     }

     private void totalRecords_Click(object sender, EventArgs e)
     {

     }

     private void View_class2_student_Load_1(object sender, EventArgs e)
     {
         level.SelectedIndex = 0;
         term.SelectedIndex = 0;
         section.SelectedIndex = 0;
        
     }
    }
}
