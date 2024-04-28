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
    public partial class Form14AddPatient : Form
    {
        public Form14AddPatient()
        {
            InitializeComponent();
        }
        public void SetPatientValues(string patientId, string firstName, string lastName, string contactNum, string admissionDate, string dischargeDate, string paymentStatus, string diagnosis)
        {
            PatPatientIDTB.Text = patientId;
            PatFnameTB.Text = firstName;
            PatLnameTB.Text = lastName;
            PatContTB.Text = contactNum;
            PatAddDateTB.Text = admissionDate;
            PatDiagTB.Text = dischargeDate;
            PatPaymentTB.Text = paymentStatus;
            PatDiagTB.Text = diagnosis;

        }
        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
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

        private void AddUserIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void AddUserIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddLnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSpecTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSpeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddContNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddContTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStatusTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                var database = new Database();
                if (database.connect_db())
                {
                    // Check if the user with the specified UserID already exists
                    string checkQuery = "SELECT COUNT(*) FROM patients WHERE PatientID = @PatientID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.mySqlConnection);
                    checkCommand.Parameters.AddWithValue("@PatientID", PatPatientIDTB.Text);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        // User already exists
                        MessageBox.Show("Patient ID already in use!");
                    }
                    else
                    {
                        // User doesn't exist, proceed with insertion
                        string insertQuery = "INSERT INTO patients VALUES (@PatientID, @FirstName, @LastName, @ContactNum, @AdmissionDate, @DischargeDate, @PaymentStatus, @Diagnosis)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.mySqlConnection);

                        insertCommand.Parameters.AddWithValue("@PatientID", PatPatientIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@FirstName", PatFnameTB.Text);
                        insertCommand.Parameters.AddWithValue("@LastName", PatLnameTB.Text);
                        insertCommand.Parameters.AddWithValue("@ContactNum", PatContTB.Text);
                        insertCommand.Parameters.AddWithValue("@AdmissionDate", PatAddDateTB.Text);
                        insertCommand.Parameters.AddWithValue("@DischargeDate", PatDiscDateTB.Text);
                        insertCommand.Parameters.AddWithValue("@PaymentStatus", PatPaymentTB.Text);
                        insertCommand.Parameters.AddWithValue("@Diagnosis", PatDiagTB.Text);


                        try
                        {
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Patient Successfully Added!");
                                ClearTextboxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Patient.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding patient: " + ex.Message);
                        }
                    }

                    database.close_db();
                }
                else
                {
                    MessageBox.Show("Database connection failed!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private bool AllFieldsFilled()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(PatPatientIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatFnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatLnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatContTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatAddDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatDiscDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatPaymentTB.Text) &&
                   !string.IsNullOrWhiteSpace(PatDiagTB.Text);
        }

        private void ClearTextboxes()
        {
            PatPatientIDTB.Text = "";
            PatFnameTB.Text = "";
            PatLnameTB.Text = "";
            PatContTB.Text = "";
            PatAddDateTB.Text = "";
            PatDiscDateTB.Text = "";
            PatPaymentTB.Text = "";
            PatDiagTB.Text = "";
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void Form14AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }
    }
}
