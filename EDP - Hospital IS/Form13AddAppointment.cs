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
    public partial class Form13AddAppointment : Form
    {
        public Form13AddAppointment()
        {
            InitializeComponent();
        }

        private void EditUserlabel_Click(object sender, EventArgs e)
        {

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

        private void AddFirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddContNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                var database = new Database();
                if (database.connect_db())
                {
                    // Check if the user with the specified AppointmentID already exists
                    string checkQuery = "SELECT COUNT(*) FROM appointments WHERE AppointmentID = @AppointmentID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.mySqlConnection);
                    checkCommand.Parameters.AddWithValue("@AppointmentID", AddAppIDTB.Text);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        // User already exists
                        MessageBox.Show("Appointment ID already in use!");
                    }
                    else
                    {
                        // User doesn't exist, proceed with insertion
                        string insertQuery = "INSERT INTO appointments VALUES (@AppointmentID, @PatientID, @UserID, @AppointmentDate, @Department)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.mySqlConnection);

                        insertCommand.Parameters.AddWithValue("@AppointmentID", AddAppIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@PatientID", AddPatientIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@UserID", AddDocIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@AppointmentDate", AddAppDateTB.Text);
                        insertCommand.Parameters.AddWithValue("@Department", AddAppDeptTB.Text);
                        try
                        {
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appoinment Successfully Booked!");
                                ClearTextboxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Book Appointment.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error booking appointment: " + ex.Message);
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
            return !string.IsNullOrWhiteSpace(AddAppIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddPatientIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddDocIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddAppDateTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddAppDeptTB.Text);

        }

        private void ClearTextboxes()
        {
            AddAppIDTB.Text = "";
            AddPatientIDTB.Text = "";
            AddDocIDTB.Text = "";
            AddAppDateTB.Text = "";
            AddAppDateTB.Text = "";
        }

        private void Form13AddAppointment_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }

        private void AddDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
