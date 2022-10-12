using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Class_Organizer : Form

    {
        View_Class1 viw = new View_Class1();
        Add_Class Add = new Add_Class();
        public Class_Organizer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beepSound();
            this.Hide();
            Add.Show();
        }

        public  void beepSound()
        {
            Console.Beep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beepSound();
            this.Hide();
            viw.Show();
        }
    }
}
