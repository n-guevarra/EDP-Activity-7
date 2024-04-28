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
    public partial class Form15Billing : Form
    {
        public Form15Billing()
        {
            InitializeComponent();
        }

        private void AddUserIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void AddAppIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db()) { 
            
                // Execute a query to retrieve the AdmissionDate and DischargeDate of the patient with the given PatientID
                string query = "SELECT AdmissionDate, DischargeDate FROM patients WHERE PatientID = @patientID";

                
                
                    using (MySqlCommand command = new MySqlCommand(query, database.mySqlConnection))
                    {
                        // Add the parameter for PatientID
                        command.Parameters.AddWithValue("@patientID", CFPatientIDTB.Text);

                        try
                        {
                           

                            // Execute the query
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Retrieve the AdmissionDate and DischargeDate from the reader
                                    DateTime admissionDate = reader.GetDateTime(0);
                                    DateTime dischargeDate = reader.GetDateTime(1);

                                    // Display the dates in appropriate TextBoxes or labels
                                    CFAddDateTB.Text = admissionDate.ToString("yyyy-MM-dd");
                                    CFDiscDateTB.Text = dischargeDate.ToString("yyyy-MM-dd");

                                    CalculateAccommodationFee(admissionDate, dischargeDate);
                                }
                                else
                                {
                                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                
            }
        }

        private void CalculateAccommodationFee(DateTime admissionDate, DateTime dischargeDate)
        {
            var database = new Database();

            if (database.connect_db())
            {

                string sqlFunction = "SELECT CalculateAccommodationFee(@admissionDate, @dischargeDate)";

                    using (MySqlCommand command = new MySqlCommand(sqlFunction, database.mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@admissionDate", admissionDate);
                        command.Parameters.AddWithValue("@dischargeDate", dischargeDate);

                        try
                        {
                            string accommodationFee = command.ExecuteScalar().ToString();
                            // string accommodationFeeString = accommodationFee.ToString();
                            CFHospFeeTB.Text = accommodationFee;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error calculating accommodation fee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
               
            }
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                var database = new Database();
                if (database.connect_db())
                {
                    // Check if the user with the specified UserID already exists
                    string checkQuery = "SELECT COUNT(*) FROM billing WHERE BillingID = @BillingID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.mySqlConnection);
                    checkCommand.Parameters.AddWithValue("@BillingID", CFBillIDTB.Text);

                    int existingBillCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingBillCount > 0)
                    {
                        // User already exists
                        MessageBox.Show("Bill ID already in use!");
                    }
                    else
                    {
                        // User doesn't exist, proceed with insertion
                        string insertQuery = "INSERT INTO billing VALUES (@BillingID, @PatientID, @AdmissionDate, @DischargeDate, @accomodation_fee)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.mySqlConnection);

                        insertCommand.Parameters.AddWithValue("@BillingID", CFBillIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@PatientID", CFPatientIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@AdmissionDate", CFAddDateTB.Text);
                        insertCommand.Parameters.AddWithValue("@DischargeDate", CFDiscDateTB.Text);
                        insertCommand.Parameters.AddWithValue("@accomodation_fee", CFHospFeeTB.Text);
                       
                        try
                        {
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Bill Successfully Added!");
                                ClearTextboxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add Bill.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding bill: " + ex.Message);
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
            return !string.IsNullOrWhiteSpace(CFBillIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(CFPatientIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(CFAddDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(CFDiscDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(CFHospFeeTB.Text);
        }

        private void ClearTextboxes()
        {
            CFBillIDTB.Text = "";
            CFPatientIDTB.Text = "";
            CFAddDateTB.Text = "";
            CFDiscDateTB.Text = "";
            CFHospFeeTB.Text = "";
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }
    }
}
