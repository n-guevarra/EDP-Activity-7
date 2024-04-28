using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP___Hospital_IS
{
    public partial class Form5Dashboard : Form
    {
        public Form5Dashboard()
        {
            InitializeComponent();
        }

        private void Form5Dashboard_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void SetFirstName(string firstName)
        {
            FirstNameLB.Text = firstName;
        }
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM appointments";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                gunaDataGridViewAppointments.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Databse Error!");
            }
        }
        private void SettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            Form13AddAppointment form13 = new Form13AddAppointment();
            form13.Show();
            this.Close();
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form14AddPatient form14 = new Form14AddPatient();
            form14.Show();
            this.Close();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newbill_Click(object sender, EventArgs e)
        {
            Form15Billing form15 = new Form15Billing();
            form15.Show();
            this.Close();
        }
    }
}
