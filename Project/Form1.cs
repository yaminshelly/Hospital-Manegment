using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Project
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
       
       
        public Form1()
        {


            InitializeComponent();
            
           

            var skinManger = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            


            this.MaximizeBox = false;
            panelAbout.Hide();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;


            Patients.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            Patients.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            Doctors.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            Rooms.BringToFront();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            Planner.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            Medicine.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            Email.BringToFront();

        }

      

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            panelAbout.BringToFront();
            panelAbout.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panelAbout.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            Patients.BringToFront();
        }

       
    }
}
