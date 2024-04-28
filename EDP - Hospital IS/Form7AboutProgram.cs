using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP___Hospital_IS
{
    public partial class Form7AboutProgram : Form
    {
        public Form7AboutProgram()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form7AboutProgram form7 = new Form7AboutProgram();
            form7.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form7AboutProgram_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }
    }
}
