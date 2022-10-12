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
    public partial class Add_Class : Form
    {
        private string courseTitle="";
        private string level = "";
        private string term = "";
        private string id;
        private  int countRecord;
        private int mode;
        private static int searchST=0;
     
      
     
        public Add_Class()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SC073EN;Initial Catalog=class_routine;Integrated Security=True");

        private void Add_Class_Load(object sender, EventArgs e)
        {
            mode = 0;
            select = 1;     
            con.Open();
            veiwAll();
            userType.Text = "";
            levelCombo.Text = "";
            termCombo.Text = "";
            semester.Text = "";
            department.Text = "";
            program.Text = "";
            campus.Text = "";
            weekday.Text = "";
            startingTime.Text = "";
            endingTime.Text = "";
            clearTextsFilds();
            searchByCombo.SelectedIndex = 0;
        }

        private void veiwAll()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from info", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            addClasses.DataSource = data;
            DataGridView dataGridviewName = addClasses;
            dataGridviewDesign(dataGridviewName);
            addClasses.Sort(addClasses.Columns[0], ListSortDirection.Descending);
            con.Close();
            //count recors
            countRecord = addClasses.Rows.Count;
            totalRecords.Text = "Total Records : " + countRecord.ToString();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 1;
            this.Hide();
            classOrganizer();
        }
    public void classOrganizer()
        {
            Class_Organizer cls = new Class_Organizer();
            cls.Show();
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 1;
            if (mode == 1 || mode == 2)
            {
                if (mode == 1)
                {

                    clearTextsFilds();
                    clearComboBoxsFilds();
                    levelCombo.Text = "";
                    termCombo.Text = "";
                }
                else if (mode == 2)
                {

                    if (userType.Text == "STUDENT")
                    {
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = false;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = true;
                    }
                    else if (userType.Text == "TEACHER")
                    {
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = true;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = false;
                    }

                    else if (mode == 2)
                    {
                        userType.Text = "--SELECT--";
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = ("");
                        department.Text = ("");
                        program.Text = ("");
                        campus.Text = ("");
                        weekday.Text = ("");
                        startingTime.Text = ("");
                        endingTime.Text = ("");
                        clearTextsFilds();


                    }


                    else
                    {
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        userType.Text = "--SELECT--";
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        clearTextsFilds();
                        clearComboBoxsFilds();
                    }
                }
                else if ((mode == 2) && (userType.Text == "STUDENT"))
                {
                    levelCombo.Text = "--SELECT--";
                    termCombo.Text = "--SELECT--";
                    semester.Text = "--SELECT--";
                    department.Text = "--SELECT--";
                    program.Text = "--SELECT--";
                    campus.Text = "--SELECT--";
                    weekday.Text = "";
                    startingTime.Text = "";
                    endingTime.Text = "";
                    room.Text = "";
                    room.ReadOnly = true;
                    courseCode.Text = "";
                    courseCode.ReadOnly = true;
                    section.Text = "";
                    section.ReadOnly = false;
                    teacherInitial.Text = "";
                    teacherInitial.ReadOnly = true;
                }
                else if ((mode == 2) && (userType.Text == "TEACHER"))
                {
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    semester.Text = "--SELECT--";
                    department.Text = "--SELECT--";
                    program.Text = "--SELECT--";
                    campus.Text = "--SELECT--";
                    weekday.Text = "";
                    startingTime.Text = "";
                    endingTime.Text = "";
                    room.Text = "";
                    room.ReadOnly = true;
                    courseCode.Text = "";
                    courseCode.ReadOnly = true;
                    section.Text = "";
                    section.ReadOnly = true;
                    teacherInitial.Text = "";
                    teacherInitial.ReadOnly = false;
                }
            }
            else
            {
                userType.Text = "";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = "";
                department.Text = "";
                program.Text = "";
                campus.Text = "";
                weekday.Text = "";
                startingTime.Text = "";
                endingTime.Text = "";
                clearTextsFilds();
             
            }

        }

        private void clearText_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 1;
            if (mode == 1 || mode == 2)
            {
                if (mode == 1)
                {
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    clearTextsFilds();
                   
                }
                else if (mode == 2)
                {

                    if (userType.Text == "STUDENT")
                    {
                     
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = false;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = true;
                    }
                    else if (userType.Text == "TEACHER")
                    {
                       
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = true;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = false;
                    }

                    else if (mode == 2)
                    {
                        userType.Text = "--SELECT--";
                     
                        clearTextsFilds();


                    }

                    else
                    {
                        
                        
                        clearTextsFilds();
                        
                    }
                }
                else if ((mode == 2) && (userType.Text == "STUDENT"))
                {
                    
                
                    room.Text = "";
                    room.ReadOnly = true;
                    courseCode.Text = "";
                    courseCode.ReadOnly = true;
                    section.Text = "";
                    section.ReadOnly = false;
                    teacherInitial.Text = "";
                    teacherInitial.ReadOnly = true;
                }
                else if ((mode == 2) && (userType.Text == "TEACHER"))
                {
                
                    room.Text = "";
                    room.ReadOnly = true;
                    courseCode.Text = "";
                    courseCode.ReadOnly = true;
                    section.Text = "";
                    section.ReadOnly = true;
                    teacherInitial.Text = "";
                    teacherInitial.ReadOnly = false;
                }
            }
            else
            {
               
                clearTextsFilds();
       
            }

        }

        private void clearTextsFilds()
        {
            room.Clear();
            courseCode.Clear();
            section.Clear();
            teacherInitial.Clear();
        }

        private void clearComboBoxs_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 1;
            if (mode == 1 || mode == 2)
            {
                if (mode == 1)
                {
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    clearComboBoxsFilds();
                }
                else if (mode == 2)
                {

                    if (userType.Text == "STUDENT")
                    {
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.ReadOnly = false;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = true;
                    }
                    else if (userType.Text == "TEACHER")
                    {
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = true;
                        teacherInitial.ReadOnly = false;
                    }
                    else if (mode == 2 && userType.Text=="STUDENT")
                    {
                        userType.Text = "STUDENT";
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                    }
                    else if (mode == 2 && userType.Text == "TEACHER")
                    {
                        userType.Text = "TEACHER";
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                    }

                    else if (mode == 2)
                    {
                        userType.Text = "--SELECT--";
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = ("");
                        department.Text = ("");
                        program.Text = ("");
                        campus.Text = ("");
                        weekday.Text = ("");
                        startingTime.Text = ("");
                        endingTime.Text = ("");
                        


                    }

                    else
                    {
                        userType.Text = "--SELECT--";
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                       
                        clearComboBoxsFilds();
                    }
                }
                else if ((mode == 2) && (userType.Text == "STUDENT"))
                {
                    levelCombo.Text = "--SELECT--";
                    termCombo.Text = "--SELECT--";
                    semester.Text = "--SELECT--";
                    department.Text = "--SELECT--";
                    program.Text = "--SELECT--";
                    campus.Text = "--SELECT--";
                    weekday.Text = "";
                    startingTime.Text = "";
                    endingTime.Text = "";
                   
                    room.ReadOnly = true;
                 
                    courseCode.ReadOnly = true;
                   
                    section.ReadOnly = false;
          
                    teacherInitial.ReadOnly = true;
                }
                else if ((mode == 2) && (userType.Text == "TEACHER"))
                {
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    semester.Text = "--SELECT--";
                    department.Text = "--SELECT--";
                    program.Text = "--SELECT--";
                    campus.Text = "--SELECT--";
                    weekday.Text = "";
                    startingTime.Text = "";
                    endingTime.Text = "";
                    
                    room.ReadOnly = true;
                  
                    courseCode.ReadOnly = true;
                  
                    section.ReadOnly = true;
                   
                    teacherInitial.ReadOnly = false;
                }
            }
            else
            {
                userType.Text = "--SELECT--";
                levelCombo.Text = "--SELECT--";
                termCombo.Text = "--SELECT--";
              
                clearComboBoxsFilds();
            }
        }

        private void clearComboBoxsFilds()
        {
            semester.Text = ("--SELECT--");
            department.Text = ("--SELECT--");
            program.Text = ("--SELECT--");
            campus.Text = ("--SELECT--");
            weekday.Text = ("--SELECT--");
            startingTime.Text = ("--SELECT--");
            endingTime.Text = ("--SELECT--");
        }

        private void program_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveOrSearchClick(object sender, EventArgs e)
        {
         
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 1;
            if (mode == 1 || mode == 2)
            
            {
                if (mode == 1)
                {

                    if ((semester.Text == "FALL 2018" || semester.Text == "SPRING 2019" || semester.Text == "SUMMER 2019" ||
                         semester.Text == "FALL 2019" || semester.Text == "SPRING 2020" || semester.Text == "SUMMER 2020" || semester.Text == "FALL 2020") && (department.Text == "CSE" || department.Text == "SWE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN" || campus.Text == "PERMANENT")
                         && (weekday.Text == "SATURDAY" || weekday.Text == "SUNDAY" || weekday.Text == "MONDAY" || weekday.Text == "TUESDAY" || weekday.Text == "WEDNESDAY" || weekday.Text == "THURSDAY" || weekday.Text == "FRIDAY") && (startingTime.Text != "--SELECT--" && startingTime.Text != "" && endingTime.Text != "--SELECT--" && endingTime.Text != "") && 
                         (room.Text != "") && (courseCode.Text != "") && (section.Text != "") && (teacherInitial.Text != ""))
                    {
                        if ((department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                        {
                            getLevelTermTitle();
                            con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("insert into info values('" + department.Text + "','" + program.Text + "','" + campus.Text + "','" + section.Text + "','" + level + "','" + term + "','" + courseCode.Text + "','" + courseTitle + "','" + teacherInitial.Text + "','" + weekday.Text + "','" + startingTime.Text + "','" + endingTime.Text + "','" + room.Text + "','" + semester.Text + "')", con);
                            sda.SelectCommand.ExecuteNonQuery();
                            con.Close();
                            //another
                            con.Open();
                            sda = new SqlDataAdapter("select * from info", con);
                            DataTable data = new DataTable();
                            sda.Fill(data);
                            addClasses.DataSource = data;
                            DataGridView dataGridviewName = addClasses;
                            dataGridviewDesign(dataGridviewName);
                            addClasses.Sort(addClasses.Columns[0], ListSortDirection.Descending);
                            con.Close();
                            countRecord = countRecord + 1;
                            totalRecords.Text = "Total Records : " + countRecord.ToString();
                            //  MessageBox.Show("Saved");
                        }
                        else { MessageBox.Show("Now This Software Only For Department :CSE,Campus :MAIN.Please Reselect Again."); }
                    }
                    else 
                    {
                        if ((countRecord == 0 || countRecord>0) && (mode == 1) && (mode != 2))
                        {

                            MessageBox.Show("Select Necsessary Options Or Fill Up Necsessary Field.");
                        }
                   
                    }
                }
                else if(countRecord!=0){
                 if ((mode == 2) && (countRecord!=0)) 
                {
                   
               if (userType.Text == "TEACHER" || userType.Text == "STUDENT")
                    {
                  if (userType.Text == "TEACHER")
                        {
                            if ((semester.Text == "FALL 2018" || semester.Text == "SPRING 2019" || semester.Text == "SUMMER 2019" ||
                   semester.Text == "FALL 2019" || semester.Text == "SPRING 2020" || semester.Text == "SUMMER 2020" || semester.Text == "FALL 2020") && (department.Text == "CSE" || department.Text == "SWE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN" || campus.Text == "PERMANENT")
                      && (teacherInitial.Text != ""))
                            {
                                if ((department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                                {
                                    searchST = 2;
                              
                                    teacherSearch();
                                }
                                else { MessageBox.Show("Now This Software Only For Department :CSE,Campus :MAIN.Please Reselect Again."); }
                            }
                            else
                            {
                                if (countRecord != 0)
                                {

                                    MessageBox.Show("Select Necsessary Options Or Fill Up Necsessary Field.");
                                }
                                else if (countRecord == 0)
                                {
                                    MessageBox.Show("There Is No Data In The Database.");
                                }
                            }
                        }
                 else if (userType.Text == "STUDENT")
                        {
                            if ((semester.Text == "FALL 2018" || semester.Text == "SPRING 2019" || semester.Text == "SUMMER 2019" ||
                    semester.Text == "FALL 2019" || semester.Text == "SPRING 2020" || semester.Text == "SUMMER 2020" || semester.Text == "FALL 2020") && (department.Text == "CSE" || department.Text == "SWE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN" || campus.Text == "PERMANENT")
                      && (levelCombo.Text == "LEVEL 1" || levelCombo.Text == "LEVEL 2" || levelCombo.Text == "LEVEL 3" || levelCombo.Text == "LEVEL 4")
                         && (termCombo.Text == "TERM 1" || termCombo.Text == "TERM 2" || termCombo.Text == "TERM 3") && (section.Text != ""))
                            {
                                if ((department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                                {
                                    searchST = 1;
                                    
                                 
                                    studentSearch();
                                }
                                else { MessageBox.Show("Now This Software Only For Department :CSE,Campus :MAIN.Please Reselect Again."); }
                            }
                            else
                            {
                                if (countRecord != 0)
                                {

                                    MessageBox.Show("Select Necsessary Options Or Fill Up Necsessary Field.");
                                }
                                else if (countRecord == 0)
                                {
                                    MessageBox.Show("There Is No Data In The Database.");
                                }
                            }
                        }
                    }
               else { MessageBox.Show("Select User Type."); }
                   
                }
                    

                }
                else if (countRecord == 0)
                {

                    MessageBox.Show("No Information Was Found In The Search");
                    countRecord = 1;
                }

                }
            else if ((mode == 0) && (countRecord == 0 || countRecord >0)) { MessageBox.Show("First Select The Mode. "); }
            else if ((mode == 2) && (countRecord == 0))
            {
                MessageBox.Show("There Is No Data In The Database");
            }
            }

        public void studentSearch()
        {
            if (mode == 2 && searchST == 1)
            {
              //  MessageBox.Show("Search Working For Student.");
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select * from info where Department = '"+department.Text+"' and Program = '"+program.Text+"' and Campus = '"+campus.Text+"' and Semester = '"+semester.Text+"' and Section = '"+section.Text+"' and Label = '"+levelCombo.Text+"'and Term = '"+termCombo.Text+"'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                addClasses.DataSource = data;
                DataGridView dataGridviewName = addClasses;
                dataGridviewDesign(dataGridviewName);
                addClasses.Sort(addClasses.Columns[0], ListSortDirection.Ascending);
                con.Close();
                //count recors
                countRecord = addClasses.Rows.Count;
                if (countRecord == 0)
                {
                    totalRecords.Text = "Search Records : " + countRecord.ToString();
                    MessageBox.Show("No Information Was Found In The Search");
                    countRecord = 1;

                }
                else
                {
                    totalRecords.Text = "Search Records : " + countRecord.ToString();
                }
            }
        }

public void teacherSearch()
        {
            if (mode == 2 && searchST == 2)
            {
                //MessageBox.Show("Search Working For Teacher.");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from info where Department='" +department.Text+"' and Program ='"+program.Text+"' and Campus = '"+campus.Text+"' and Teacher_Initial = '"+teacherInitial.Text+"' and Semester ='"+semester.Text+"' ", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                addClasses.DataSource = data;
                DataGridView dataGridviewName = addClasses;
                dataGridviewDesign(dataGridviewName);
                addClasses.Sort(addClasses.Columns[0], ListSortDirection.Ascending);
                con.Close();
                //count recors
                countRecord = addClasses.Rows.Count;
                if (countRecord == 0)
                {
                    totalRecords.Text = "Search Records : " + countRecord.ToString();
                    MessageBox.Show("No Information Was Found In The Search");
                    countRecord = 1;

                }
                else
                {
                    totalRecords.Text = "Search Records : " + countRecord.ToString();
                }
            }
        }

        private void getLevelTermTitle()
        {

            if (program.Text == "DAY")
            {
                if (courseCode.Text == "CSE 112")
                {
                    courseTitle = "Computer Fundamentals";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "MAT 111")
                {
                    courseTitle = "Mathematics – I: Differential and Integral Calculus";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "ENG 113")
                {
                    courseTitle = "Basic Functional English and English Spoken";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "PHY 113")
                {
                    courseTitle = "Physics-I: Mechanics: Heat & Thermodynamics: Waves: Optics";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "MAT 121")
                {
                    courseTitle = "Mathematics – II: Linear Algebra and Coordinate Geometry";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 122")
                {
                    courseTitle = "Programming and Problem Solving";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 123")
                {
                    courseTitle = "Problem Solving Lab";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "PHY 123")
                {
                    courseTitle = "Physics - II: Electricity: Magnetism and Modern Physics";
                    level = "LEVEL 1";
                    term = "TERM 2";

                }
                else if (courseCode.Text == "PHY 124")
                {
                    courseTitle = "Physics - II Lab";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "ENG 123")
                {
                    courseTitle = "Writing and Comprehension";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 131")
                {
                    courseTitle = "Discrete Mathematics";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 132")
                {
                    courseTitle = "Electrical Circuits";
                    level = "LEVEL 1";
                    term = "TERM 3";

                }
                else if (courseCode.Text == "CSE 133")
                {
                    courseTitle = "Electrical Circuits Lab";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 134")
                {
                    courseTitle = "Data Structures";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 135")
                {
                    courseTitle = "Data Structures Lab";
                    level = "LEVEL 1";
                    term = "TERM 3";

                }
                else if (courseCode.Text == "MAT 131")
                {
                    courseTitle = "Mathematics – III: Ordinary and Partial Differential Equations";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "MAT 211")
                {
                    courseTitle = "Mathematics-IV: Engineering Mathematics";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 212")
                {
                    courseTitle = "Digital Electronics";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 213")
                {
                    courseTitle = "Digital Electronics Lab";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 214")
                {
                    courseTitle = "Object Oriented Programming";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 215")
                {
                    courseTitle = "Object Oriented Programming Lab";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "GED 201")
                {
                    courseTitle = "Bangladesh Studies";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 221")
                {
                    courseTitle = "Algorithm";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 222")
                {
                    courseTitle = "Algorithm Lab";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "STA 133")
                {
                    courseTitle = "Statistics and Probability";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 224")
                {
                    courseTitle = "Electronic Devices and Circuits";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 225")
                {
                    courseTitle = " Electronic Devices and Circuits Lab";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 231")
                {
                    courseTitle = " Microprocessor and Assembly Language";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 232")
                {
                    courseTitle = "Microprocessor and Assembly Language Lab";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 233")
                {
                    courseTitle = "Data Communication";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 234")
                {
                    courseTitle = " Numerical Methods";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 235")
                {
                    courseTitle = "Introduction to Bio-Informatics";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 311")
                {
                    courseTitle = "Database Management System";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 312")
                {
                    courseTitle = "Database Management System Lab";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 313")
                {
                    courseTitle = "Computer Network";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 314")
                {
                    courseTitle = "Computer Network Lab";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "GED 321")
                {
                    courseTitle = "Art of Living";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 321")
                {
                    courseTitle = "System Analysis and Design";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 322")
                {
                    courseTitle = "Computer Architecture and Organization";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 323")
                {
                    courseTitle = "Operating System";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 324")
                {
                    courseTitle = " Operating System Lab";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "ECO 314")
                {
                    courseTitle = "Economics";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 331")
                {
                    courseTitle = "Compiler Design";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 332")
                {
                    courseTitle = "Compiler Design lab";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 333")
                {
                    courseTitle = "Software Engineering";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 334")
                {
                    courseTitle = "Wireless Programming";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "ACT 301")
                {
                    courseTitle = "Financial and Managerial Accounting";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 412")
                {
                    courseTitle = "Artificial Intelligence";
                    level = "LEVEL 4";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 413")
                {
                    courseTitle = "Artificial Intelligence Lab";
                    level = "LEVEL 4";
                    term = "TERM 1";

                }
                else if (courseCode.Text == "CSE 414")
                {
                    courseTitle = "Simulation and Modeling";
                    level = "LEVEL 4";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 415")
                {
                    courseTitle = "Simulation and Modeling Lab";
                    level = "LEVEL 4";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 417")
                {
                    courseTitle = "Web Engineering";
                    level = "LEVEL 4";
                    term = "TERM 1";

                }
                else if (courseCode.Text == "CSE 418")
                {
                    courseTitle = "Web Engineering Lab";
                    level = "LEVEL 4";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 421")
                {
                    courseTitle = "Computer Graphics";
                    level = "LEVEL 4";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 422")
                {
                    courseTitle = "Computer Graphics Lab";
                    level = "LEVEL 4";
                    term = "TERM 2";

                }
                else if (courseCode.Text == "CSE 423")
                {
                    courseTitle = "Embedded System";
                    level = "LEVEL 4";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 450")
                {
                    courseTitle = "Data Mining";
                    level = "LEVEL 4";
                    term = "TERM 2";

                }
                else if (courseCode.Text == "CSE 499")
                {
                    courseTitle = "* Project / Internship (Phase I)";
                    level = "LEVEL 4";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 433")
                {
                    courseTitle = "Digital Image Processing";
                    level = "LEVEL 4";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 498")
                {
                    courseTitle = "Social and Professional Issues in Computing";
                    level = "LEVEL 4";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 499")
                {
                    courseTitle = "* Project / Internship (Phase II)";
                    level = "LEVEL 4";
                    term = "TERM 3";
                }
                else
                {
                    courseCode.Text = "NONE";
                    courseTitle = "NONE";
                    level = "NONE";
                    term = "NONE";
                }
            }
          else if (program.Text == "EVENING" )
            {
                if (courseCode.Text == "MAT 121")
                {
                    courseTitle = "Mathematics II: Linear algebra and Coordinate Geometry";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 131")
                {
                    courseTitle = " Discrete Mathematics";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "ENG 113")
                {
                    courseTitle = "English Language-I";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "PHY 123")
                {
                    courseTitle = "Physics- II: Electricity, Magnetism and Modern Physics";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "PHY 123 L")
                {
                    courseTitle = "Physics-II Lab";
                    level = "LEVEL 1";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 213")
                {
                    courseTitle = "Algorithms";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 213 L")
                {
                    courseTitle = " Algorithms Lab";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "ACC 214")
                {
                    courseTitle = "Accounting";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "ECO 314")
                {
                    courseTitle = "Economics";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "MAT 134")
                {
                    courseTitle = "Mathematics III : Ordinary and Partial Differential Equations";
                    level = "LEVEL 1";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 221")
                {
                    courseTitle = "Theory of Computing";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 222")
                {
                    courseTitle = "Object Oriented Programming";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 222 L")
                {
                    courseTitle = "Object Oriented Programming Lab";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "MAT 211")
                {
                    courseTitle = "Mathematics-IV : Engineering Mathematics";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "MAT 223")
                {
                    courseTitle = "Statistics";
                    level = "LEVEL 1";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 231")
                {
                    courseTitle = "Microprocessor and Assembly Language";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 231 L")
                {
                    courseTitle = "Microprocessor and Assembly Language Lab";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 224")
                {
                    courseTitle = "Electronic Devices and Circuits";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 224 L")
                {
                    courseTitle = "Electronic Devices and Circuits Lab";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 232")
                {
                    courseTitle = "Instrumentation and Control";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 233")
                {
                    courseTitle = "Data Communication";
                    level = "LEVEL 2";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 322")
                {
                    courseTitle = "Computer Architecture and Organization";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 313")
                {
                    courseTitle = "Computer Networks";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 313 L")
                {
                    courseTitle = "Computer Networks Lab";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 311")
                {
                    courseTitle = "Database Management System";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 311 L")
                {
                    courseTitle = "Database Management System Lab";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 312")
                {
                    courseTitle = "Numerical Methods";
                    level = "LEVEL 2";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 331")
                {
                    courseTitle = "Compiler Design";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 331 L")
                {
                    courseTitle = "Compiler Design Lab";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 413")
                {
                    courseTitle = "Simulation and Modeling";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 413 L")
                {
                    courseTitle = "Simulation and Modeling Lab";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 323")
                {
                    courseTitle = "Operating System";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 323 L")
                {
                    courseTitle = "Operating System Lab";
                    level = "LEVEL 2";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 321")
                {
                    courseTitle = "System Analysis and Design";
                    level = "LEVEL 3";
                    term = "TERM 1";

                }
                else if (courseCode.Text == "CSE 321 L")
                {
                    courseTitle = "System Analysis and Design Lab";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 421")
                {
                    courseTitle = "Computer Graphics";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 421 L")
                {
                    courseTitle = "Computer Graphics Lab";
                    level = "LEVEL 3";
                    term = "TERM 1";

                }
                else if (courseCode.Text == "CSE 431")
                {
                    courseTitle = "E-Commerce & Web Application";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "MGT 414")
                {
                    courseTitle = "Industrial Management";
                    level = "LEVEL 3";
                    term = "TERM 1";
                }
                else if (courseCode.Text == "CSE 411")
                {
                    courseTitle = "Communication Engineering";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 412")
                {
                    courseTitle = "Artificial Intelligence";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 412 L")
                {
                    courseTitle = "Artificial Intelligence Lab";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 332")
                {
                    courseTitle = "Software Engineering";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 499")
                {
                    courseTitle = "Project/Internship (Phase I)";
                    level = "LEVEL 3";
                    term = "TERM 2";
                }
                else if (courseCode.Text == "CSE 333")
                {
                    courseTitle = "Peripherals and Interfacing";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 432")
                {
                    courseTitle = "Computer and Network Security";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else if (courseCode.Text == "CSE 499")
                {
                    courseTitle = "Project/Internship (Phase II)";
                    level = "LEVEL 3";
                    term = "TERM 3";
                }
                else
                {
                    courseCode.Text = "NONE";
                    courseTitle = "NONE";
                    level = "NONE";
                    term = "NONE";
                }

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
       private void update_Click(object sender, EventArgs e)
        {
            
           Class_Organizer b = new Class_Organizer();
            b.beepSound();
           
            if (select == 0)
            {
                if ((department.Text == "CSE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN"))
                {

                    if ((semester.Text == "FALL 2018" || semester.Text == "SPRING 2019" || semester.Text == "SUMMER 2019" ||
                   semester.Text == "FALL 2019" || semester.Text == "SPRING 2020" || semester.Text == "SUMMER 2020" || semester.Text == "FALL 2020") && (department.Text == "CSE" || department.Text == "SWE") && (program.Text == "DAY" || program.Text == "EVENING") && (campus.Text == "MAIN" || campus.Text == "PERMANENT")
                   && (weekday.Text == "SATURDAY" || weekday.Text == "SUNDAY" || weekday.Text == "MONDAY" || weekday.Text == "TUESDAY" || weekday.Text == "WEDNESDAY" || weekday.Text == "THURSDAY" || weekday.Text == "FRIDAY") && (startingTime.Text != "--SELECT--" && startingTime.Text != "" && endingTime.Text != "--SELECT--" && endingTime.Text != "") &&
                   (room.Text != "") && (courseCode.Text != "") && (section.Text != "") && (teacherInitial.Text != ""))
                    {
                        select = 1;
                        getLevelTermTitle();

                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("update info set Department='" + department.Text + "',Program='" + program.Text + "',Campus='" + campus.Text + "',Section='" + section.Text + "',Label='" + level + "',Term='" + term + "',Course_Code='" + courseCode.Text + "',Course_Title='" + courseTitle + "',Teacher_Initial='" + teacherInitial.Text + "',Weekday='" + weekday.Text + "',Starting_Time='" + startingTime.Text + "',Ending_Time='" + endingTime.Text + "',Room='" + room.Text + "',Semester='" + semester.Text + "' where ID='" + id + "'", con);
                        sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        //another
                      // sda = searchTestTeacher(sda);

                        if (mode == 2 || mode == 1)
                        {
                            if ((mode == 2) && (userType.Text == "TEACHER"))
                            {
                                userType.Text = "TEACHER";
                                levelCombo.Text = "";
                                termCombo.Text = "";
                                weekday.Text = ("");
                                startingTime.Text = ("");
                                endingTime.Text = ("");
                                room.Text = ("");
                                section.Text = ("");
                                courseCode.Text = ("");
                            }
                            else if ((mode == 2) && (userType.Text == "STUDENT"))
                            {
                                userType.Text = "STUDENT";
                                weekday.Text = ("");
                                startingTime.Text = ("");
                                endingTime.Text = ("");
                                room.Text = ("");
                                teacherInitial.Text = "";
                                courseCode.Text = ("");
                            }
                            else if (mode == 2)
                            {
                                userType.Text = "--SELECT--";
                                levelCombo.Text = "";
                                termCombo.Text = "";
                                semester.Text = ("");
                                department.Text = ("");
                                program.Text = ("");
                                campus.Text = ("");
                                weekday.Text = ("");
                                startingTime.Text = ("");
                                endingTime.Text = ("");

                            }
                            else if (mode == 1)
                            {
                                userType.Text = "";
                                levelCombo.Text = "";
                                termCombo.Text = "";
                                semester.Text = ("");
                                department.Text = ("");
                                program.Text = ("");
                                campus.Text = ("");
                                weekday.Text = ("");
                                startingTime.Text = ("");
                                endingTime.Text = ("");
                            }
                            else
                            {
                                levelCombo.Text = "";
                                termCombo.Text = "";
                                semester.Text = ("");
                                department.Text = ("");
                                program.Text = ("");
                                campus.Text = ("");
                                weekday.Text = ("");
                                startingTime.Text = ("");
                                endingTime.Text = ("");
                            }
                            if (mode == 1)
                            {
                                semester.Text = "--SELECT--";
                                department.Text = "--SELECT--";
                                program.Text = "--SELECT--";
                                campus.Text = "--SELECT--";
                                weekday.Text = "--SELECT--";
                                startingTime.Text = "--SELECT--";
                                endingTime.Text = "--SELECT--";

                            }
                            if ((mode != 2) &&( (userType.Text != "TEACHER") || (userType.Text != "STUDENT")))
                            {
                            clearTextsFilds();
                            }
                        }

                        veiwAll();

                        MessageBox.Show("Updated.");
                        if (mode == 0)
                        {
                            clearTextsFilds();
                            levelCombo.Text = "";
                            termCombo.Text = "";
                            semester.Text = ("");
                            department.Text = ("");
                            program.Text = ("");
                            campus.Text = ("");
                            weekday.Text = ("");
                            startingTime.Text = ("");
                            endingTime.Text = ("");

                        }

                    }
                    else { MessageBox.Show("Select All Options Or Fill Up All Fields."); }
                }

                else { MessageBox.Show("Now This Software Only For Department :CSE,Campus :MAIN.Please Reselect Again."); }
            }
            else if (select != 0) { MessageBox.Show("Slect Any Row For Updating."); }
          }

       private SqlDataAdapter searchTestTeacher(SqlDataAdapter sda)
       {
           if (mode == 2 && searchST == 2)
           {
               teacherSearch();

           }
           else if (mode == 2 && searchST == 1)
           {
            
               studentSearch();
           }
           else if ((mode != 2 && searchST != 2) && (mode != 2 && searchST != 1))
           {
               con.Open();
               sda = new SqlDataAdapter("select * from info", con);
               DataTable data = new DataTable();
               sda.Fill(data);
               addClasses.DataSource = data;
               DataGridView dataGridviewName = addClasses;
               dataGridviewDesign(dataGridviewName);
               addClasses.Sort(addClasses.Columns[0], ListSortDirection.Descending);
               con.Close();
           }
           return sda;
       }


        private void delete_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
          
          if(select==0)
            {
             select = 1;
             getLevelTermTitle();

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("delete from info where ID='" + id + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            //another
            con.Open();
            sda = new SqlDataAdapter("select * from info", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if ((mode != 2) && ((userType.Text != "TEACHER") || (userType.Text != "STUDENT")))
            {
                addClasses.DataSource = data;
            }
            DataGridView dataGridviewName = addClasses;
            dataGridviewDesign(dataGridviewName);
            if (mode == 1)
            {
                addClasses.Sort(addClasses.Columns[0], ListSortDirection.Descending);
            }
            con.Close();
           
            if (mode == 1)
            {
                semester.Text = "--SELECT--";
                department.Text = "--SELECT--";
                program.Text = "--SELECT--";
                campus.Text = "--SELECT--";
                weekday.Text = "--SELECT--";
                startingTime.Text = "--SELECT--";
                endingTime.Text = "--SELECT--";

            }
            if (mode == 1)
            {
                countRecord = countRecord - 1;
            }
            if (mode != 1)
            {
                totalRecords.Text = "";
            }
            if (countRecord < 0) { countRecord = 0; }
            if (mode == 1)
            {
                totalRecords.Text = "Total Records : " + countRecord.ToString();
            }
            if (mode == 2)
            {
                if ((mode == 2) && (userType.Text == "TEACHER"))
                {
                    userType.Text = "TEACHER";
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    weekday.Text = ("");
                    startingTime.Text = ("");
                    endingTime.Text = ("");
                    room.Text = ("");
                    section.Text = ("");
                    courseCode.Text = ("");
                }
                else if ((mode == 2) && (userType.Text == "STUDENT"))
                {
                    userType.Text = "STUDENT";
                    weekday.Text = ("");
                    startingTime.Text = ("");
                    endingTime.Text = ("");
                    room.Text = ("");
                    teacherInitial.Text = "";
                    courseCode.Text = ("");
                }
                else if (mode == 2)
                {
                   
                    
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    semester.Text = ("");
                    department.Text = ("");
                    program.Text = ("");
                    campus.Text = ("");
                    weekday.Text = ("");
                    startingTime.Text = ("");
                    endingTime.Text = ("");
                    clearTextsFilds();
                }
                
         
           
            }
            if ((mode != 2) && ((userType.Text != "TEACHER") || (userType.Text != "STUDENT")))
            {
                userType.Text = "";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = ("");
                department.Text = ("");
                program.Text = ("");
                campus.Text = ("");
                weekday.Text = ("");
                startingTime.Text = ("");
                endingTime.Text = ("");
                clearTextsFilds();
            }
            MessageBox.Show("Deleted");
            if (mode == 1)
            {
                userType.Text = "";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = "--SELECT--";
                department.Text = "--SELECT--";
                program.Text = "--SELECT--";
                campus.Text = "--SELECT--";
                weekday.Text = "--SELECT--";
                startingTime.Text = "--SELECT--";
                endingTime.Text = "--SELECT--";
                room.Text = "";
                room.ReadOnly = false;
                courseCode.Text = "";
                courseCode.ReadOnly = false;
                section.Text = "";
                section.ReadOnly = false;
                teacherInitial.Text = "";
                teacherInitial.ReadOnly = false;
            }
          }
            else if (select != 0) { MessageBox.Show("Slect Any Row For Deleting."); }
            
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            
            countRecord = addClasses.Rows.Count;
            select = 1;
            if (countRecord > 0)
            {
                if (MessageBox.Show("Do You Want To Delete All Records From Table ? If You Delete All Records From Table Then They Will Be No Longer In The Database.", "                                                           Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    //delete table from database
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("drop table info", con);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    addClasses.DataSource = data;
                    DataGridView dataGridviewName = addClasses;
                    dataGridviewDesign(dataGridviewName);

                    con.Close();
                    clearTextsFilds();
                    userType.Text = "";
                    if (mode == 2)
                    { userType.Text = "--SELECT--"; }                   
                    levelCombo.Text = "";
                    termCombo.Text = "";
                    semester.Text = "";
                    department.Text = "";
                    program.Text = "";
                    campus.Text = "";
                    weekday.Text = "";
                    startingTime.Text = "";
                    endingTime.Text = "";
                    clearTextsFilds();
                    // create table in database
                    con.Open();
                    sda = new SqlDataAdapter(@"Create table info
(ID int identity(1,1),
Department varchar(30),
Program varchar(10),
Campus varchar(10),
Section varchar(5),
Label varchar(10),
Term varchar(10),
Course_Code varchar(10),
Course_Title varchar(500),
Teacher_Initial varchar(10),
Weekday varchar(20),
Starting_Time varchar(10), 
Ending_Time varchar(10),
Room varchar(20),
Semester varchar(20))", con);

                    sda.Fill(data);
                    addClasses.DataSource = data;

                    dataGridviewDesign(dataGridviewName);
                    con.Close();
                    countRecord = 0;
                    totalRecords.Text = "Total Records : " + countRecord.ToString();

                }
                else
                {
                }

            }
            else if (countRecord == 0) { MessageBox.Show("There Is No Record In The Database."); }
            if (mode == 1)
            {
                userType.Text = "";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = "--SELECT--";
                department.Text = "--SELECT--";
                program.Text = "--SELECT--";
                campus.Text = "--SELECT--";
                weekday.Text = "--SELECT--";
                startingTime.Text = "--SELECT--";
                endingTime.Text = "--SELECT--";
                room.Text = "";
                room.ReadOnly = false;
                courseCode.Text = "";
                courseCode.ReadOnly = false;
                section.Text = "";
                section.ReadOnly = false;
                teacherInitial.Text = "";
                teacherInitial.ReadOnly = false;
            }
        }


        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void roomDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                courseCode.Focus();
            }
        }

        private void courseCodeDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                section.Focus();
            }
        }

        private void sectionDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                teacherInitial.Focus();
            }
        }

        private void teacherInitialDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // save.PerformClick();
                saveOrSearch.Focus();
            }
        }
        public int select;
        private void addClasses_MouseClick(object sender, MouseEventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            select = 0;
            if (addClasses.RowCount > 0)
            {
                if (mode == 2 && userType.Text == "STUDENT")
                { userType.Text = "STUDENT"; }
                else  if (mode == 2 && userType.Text == "TEACHER")
                { userType.Text = "TEACHER"; }
                else if (mode == 2)
                {
                    userType.Text = "--SELECT--";
                }
                else
                {
                    userType.Text = "";
                }
                levelCombo.Text = "";
                termCombo.Text = "";
                room.ReadOnly = false;
                courseCode.ReadOnly = false;
                section.ReadOnly = false;
                teacherInitial.ReadOnly = false;
                id = addClasses.SelectedRows[0].Cells[0].Value.ToString();
                department.Text = addClasses.SelectedRows[0].Cells[1].Value.ToString();
                program.Text = addClasses.SelectedRows[0].Cells[2].Value.ToString();
                campus.Text = addClasses.SelectedRows[0].Cells[3].Value.ToString();
                section.Text = addClasses.SelectedRows[0].Cells[4].Value.ToString();
                level = addClasses.SelectedRows[0].Cells[5].Value.ToString();
                term = addClasses.SelectedRows[0].Cells[6].Value.ToString();
                levelCombo.Text = addClasses.SelectedRows[0].Cells[5].Value.ToString();
                termCombo.Text = addClasses.SelectedRows[0].Cells[6].Value.ToString();
                courseCode.Text = addClasses.SelectedRows[0].Cells[7].Value.ToString();
                courseTitle = addClasses.SelectedRows[0].Cells[8].Value.ToString();
                teacherInitial.Text = addClasses.SelectedRows[0].Cells[9].Value.ToString();
                weekday.Text = addClasses.SelectedRows[0].Cells[10].Value.ToString();
                startingTime.Text = addClasses.SelectedRows[0].Cells[11].Value.ToString();
                endingTime.Text = addClasses.SelectedRows[0].Cells[12].Value.ToString();
                room.Text = addClasses.SelectedRows[0].Cells[13].Value.ToString();
                semester.Text = addClasses.SelectedRows[0].Cells[14].Value.ToString();
            }

            else
            {
                MessageBox.Show("Slect Any Row For Updating Or Deleting.");
            }
            
      }

        private void search_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               Class_Organizer b = new Class_Organizer();
               b.beepSound();
        }

        private void addClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void saveMode_CheckedChanged(object sender, EventArgs e)
        {
            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            veiwAll();
            mode = 1;
            searchST = 0;
            saveOrSearch.Text = "Save";
            userType.Text = "";
            levelCombo.Text = "";
            termCombo.Text = "";
            semester.Text = "--SELECT--";
            department.Text = "--SELECT--";
            program.Text = "--SELECT--";
            campus.Text = "--SELECT--";
            weekday.Text = "--SELECT--";
            startingTime.Text = "--SELECT--";
            endingTime.Text = "--SELECT--";
            room.Text = "";
            room.ReadOnly = false;
            courseCode.Text = "";
            courseCode.ReadOnly = false;
            section.Text = "";
            section.ReadOnly = false;
            teacherInitial.Text = "";
            teacherInitial.ReadOnly = false;

        }

        private void searchMode_CheckedChanged(object sender, EventArgs e)
        {

            Class_Organizer b = new Class_Organizer();
            b.beepSound();
            addClasses.Sort(addClasses.Columns[0], ListSortDirection.Ascending);
            searchST = 0;
           
            if (countRecord == 0) 
            {
                mode = 2;
                MessageBox.Show("There Is No Data In The Database.");
                saveOrSearch.Text = "Search";
                userType.Text = "--SELECT--";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = "";
                department.Text = "";
                program.Text = "";
                campus.Text = "";
                weekday.Text = "";
                startingTime.Text = "";
                endingTime.Text = "";
                room.Text = "";
                room.ReadOnly = true;
                courseCode.Text = "";
                courseCode.ReadOnly = true;
                section.Text = "";
                section.ReadOnly = true;
                teacherInitial.Text = "";
                teacherInitial.ReadOnly = true;
            }
            else if (countRecord >0)
            {
                
                mode = 2;
                saveOrSearch.Text = "Search";
                userType.Text = "--SELECT--";
                levelCombo.Text = "";
                termCombo.Text = "";
                semester.Text = "";
                department.Text = "";
                program.Text = "";
                campus.Text = "";
                weekday.Text = "";
                startingTime.Text = "";
                endingTime.Text = "";
                room.Text = "";
                room.ReadOnly = true;
                courseCode.Text = "";
                courseCode.ReadOnly = true;
                section.Text = "";
                section.ReadOnly = true;
                teacherInitial.Text = "";
                teacherInitial.ReadOnly = true;
            }

            
            
        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == 2)
            {
                if (userType.Text == "STUDENT" || userType.Text == "TEACHER")
                {


                    if (userType.Text == "STUDENT")
                    {
                       // MessageBox.Show(" STUDENT");
                   
                        levelCombo.Text = "--SELECT--";
                        termCombo.Text = "--SELECT--";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = false;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = true;
                    }
                    else if (userType.Text == "TEACHER")
                    {
                       // MessageBox.Show(" TEACHER");
                     
                        levelCombo.Text = "";
                        termCombo.Text = "";
                        semester.Text = "--SELECT--";
                        department.Text = "--SELECT--";
                        program.Text = "--SELECT--";
                        campus.Text = "--SELECT--";
                        weekday.Text = "";
                        startingTime.Text = "";
                        endingTime.Text = "";
                        room.Text = "";
                        room.ReadOnly = true;
                        courseCode.Text = "";
                        courseCode.ReadOnly = true;
                        section.Text = "";
                        section.ReadOnly = true;
                        teacherInitial.Text = "";
                        teacherInitial.ReadOnly = false;
                    }
                }
                else if ((userType.Text != "STUDENT") && (userType.Text != "TEACHER"))
                {
                    MessageBox.Show("Select User Type.");
                }
            }
        }
 


















        private void search_TextChanged_1(object sender, EventArgs e)
        {
            if ((searchByCombo.Text != "----------SELECT----------") && (searchByCombo.Text != ""))
            {  
                if(searchByCombo.Text=="ID")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where ID like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                else if(searchByCombo.Text=="LEVEL")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Label like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="TERM")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Term like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="SEMESTER")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Semester like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="DEPARTMENT")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Department like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="PROGRAM")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Program like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="CAMPUS")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Campus like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="WEEK DAY")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Weekday like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="STARTING TIME")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Starting_Time like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="ENDING TIME")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where  Ending_Time like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="ROOM")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where  Room like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="COURSE CODE")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where  Course_Code like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                else if (searchByCombo.Text == "COURSE TITLE")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where  Course_Title like '" + search.Text + "%' order by ID", con);
                    searchTableDesign(sda);
                }
                 else if(searchByCombo.Text=="SECTION")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where Section like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                else if (searchByCombo.Text == "TEACHER INITIAL")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from info where  Teacher_Initial like '" + search.Text + "%' order by ID", con);
                searchTableDesign(sda);
                }
                
                
            }
            else 
            {
                MessageBox.Show("Please Select Any Field.");
            }
            if (countRecord == 0)
            {
                countRecord = 1;
            }
        }

        private void searchTableDesign(SqlDataAdapter sda)
        {
            DataTable data = new DataTable();
            sda.Fill(data);
            addClasses.DataSource = data;
            DataGridView dataGridviewName = addClasses;
            dataGridviewDesign(dataGridviewName);
           // addClasses.Sort(addClasses.Columns[0], ListSortDirection.Descending);
            con.Close();
            //count recors
            countRecord = addClasses.Rows.Count;
            totalRecords.Text = "Search Records : " + countRecord.ToString();
            if (countRecord == 0)
            {
                countRecord = 1;
            }
        }
        
        
       
       
        
       
      

       
      
    }
}
