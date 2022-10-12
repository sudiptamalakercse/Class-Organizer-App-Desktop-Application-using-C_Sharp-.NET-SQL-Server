using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{

    public partial class View_Class1 : Form
    {
   private static string _program;
   private static string _semester;
   private static string _campus;
   private static string _department;
 
        public View_Class1()
        {
            InitializeComponent();
        }

        public string get_program()
        { 
        return _program;
        }

        public string get_semester()
        {
            return _semester;
        }
        public string get_campus()
        {
            return _campus;
        }
        
        public string get_department()
        {
            return _department;
        }
        public void set_department(string department)
        {
            _department = department;
        }
        public void set_semester(string semester)
        {
            _semester = semester;
        }
        public void set_campus(string campus)
        {
            _campus = campus;

        }
        public void set_program(string program)
        {
            _program = program;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            this.Hide();
            Add_Class ad = new Add_Class();

            ad.classOrganizer();



        }



        private void View_Class_Load(object sender, EventArgs e)
        {
            userType.SelectedIndex = 0;
            semester.SelectedIndex = 0;
            department.SelectedIndex = 0;
            program.SelectedIndex = 0;
            campus.SelectedIndex = 0;
        }

       

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void semester_MouseClick(object sender, MouseEventArgs e)
        {
          

        }

     public  void viewClass3Teacher()
        {
            View_class3_teacher te = new View_class3_teacher();
            te.Show();
            
        }

        public  void viewClass2Student()
        {
            View_class2_student st = new View_class2_student();
            st.Show();
        }

        private void View_Class1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

        }
        private int count = 0;

        private void next_Click_1(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
             
            if (count >= 5 && (userType.Text == "STUDENT" || userType.Text == "TEACHER")&&(semester.Text=="FALL 2018"||semester.Text== "SPRING 2019"||semester.Text=="SUMMER 2019"||
                semester.Text == "FALL 2019" || semester.Text == "SPRING 2020" || semester.Text == "SUMMER 2020" || semester.Text == "FALL 2020") && (department.Text == "CSE" || department.Text == "SWE") && (program.Text == "DAY" || program.Text == "EVENING")&& (campus.Text == "MAIN" || campus.Text == "PERMANENT"))
            {
                if ((userType.Text == "STUDENT")  && (department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                {
                    set_campus(this.campus.Text);
                    set_department(this.department.Text);
                    set_semester(this.semester.Text);
                    set_program(this.program.Text);
                      
                    viewClass2Student();
                    this.Hide();
                }

                else if ((userType.Text == "TEACHER") && (department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                {

                    set_campus(this.campus.Text);
                    set_department(this.department.Text);
                    set_semester(this.semester.Text);
                    set_program(this.program.Text);
                    
                    
                    viewClass3Teacher();
                   this.Hide();
                   
                    
                }
                else { MessageBox.Show("Now informations are available  only for Department :CSE,Campus :MAIN.Please reselect again. "); }
            }
            else {
                MessageBox.Show ("Select All Options");
            }
            }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
        }

        private void semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
        }

        private void program_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            count++;
        }

        private void campus_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
        }
     
        }
    }

