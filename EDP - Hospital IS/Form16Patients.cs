using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class Form16Patients : Form
    {
        private string placeholderTextSearch = "Search";
        public Form16Patients()
        {
            InitializeComponent();
            InitializeSearchBox();
            ConfigureDataGridView(gunaGridViewAllPatients);
            gunaGridViewAllPatients.CellContentClick += gunaGridViewAllUsers_CellContentClick;
            SearchBox.TextChanged += SearchBox_TextChanged;
        }
        private void ConfigureDataGridView(GunaDataGridView gunaGridViewAllUsers)
        {
            // FIX
            foreach (DataGridViewColumn column in gunaGridViewAllUsers.Columns)
            {
                int textLength = TextRenderer.MeasureText(column.HeaderText, gunaGridViewAllUsers.Font).Width;
                column.Width = textLength + 20; // Adjust the padding as needed
            }

            gunaGridViewAllUsers.AllowUserToResizeRows = false; // Disable row resizing


        }
        private void InitializeSearchBox()
        {
            SearchBox.Text = placeholderTextSearch;
            SearchBox.ForeColor = System.Drawing.Color.Gray;
            SearchBox.Padding = new Padding(0, 5, 0, -5);
            SearchBox.GotFocus += SearchBox_GotFocus;
            SearchBox.LostFocus += SearchBox_LostFocus;
        }

        private void SearchBox_GotFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (textBox.Text == placeholderTextSearch)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SearchBox_LostFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBoxSearch = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = placeholderTextSearch;
                textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void Form16Patients_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM patients";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                gunaGridViewAllPatients.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Databse Error!");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGridViewAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaGridViewAllPatients.Columns[e.ColumnIndex].Name == "C1EditPatient")
            {

                // Get the selected user's details from the DataGridView
                string patientId = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                string firstName = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                string lastName = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                string contactNum = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["ContactNum"].Value.ToString();
                string admissionDate = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["AdmissionDate"].Value.ToString();
                string dischargeDate = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["Discharge"].Value.ToString();
                string paymentStatus = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["PaymentStatus"].Value.ToString();
                string diagnosis = gunaGridViewAllPatients.Rows[e.RowIndex].Cells["Diagnosis"].Value.ToString();

                Form14AddPatient patientForm = new Form14AddPatient();
                patientForm.SetPatientValues(patientId, firstName, lastName, contactNum, admissionDate, dischargeDate, paymentStatus, diagnosis);
                patientForm.ShowDialog();

            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var database = new Database();

            if (database.connect_db())
            {
                string searchTerm = SearchBox.Text.Trim();
                string query = "SELECT * FROM patients WHERE CONCAT(PatientID, FirstName, LastName, ContactNum, AdmissionDate, DischargeDate, PaymentStatus, Diagnosis) LIKE @SearchTerm";

                using (MySqlCommand cmd = new MySqlCommand(query, database.mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    try
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Display the results in the DataGridView
                            gunaGridViewAllPatients.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error executing search query: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Database connection is not open.");
            }
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            Form7AboutProgram form7 = new Form7AboutProgram();
            form7.Show();
            this.Close();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }
    }
}
