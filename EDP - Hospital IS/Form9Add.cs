using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP___Hospital_IS
{
    public partial class Form9Add : Form
    {
        public Form9Add()
        {
            InitializeComponent();
        }

        private void Form9Add_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddPassLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {

        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditStatusTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditContTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditSpecTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditLnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditFnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditUserIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddContNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddSpeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddFirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddUserIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditUserlabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void UsersBtn_Click_1(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void DashboardBtn_Click_1(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void ReportsBtn_Click_1(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void AboutBtn_Click_1(object sender, EventArgs e)
        {
            Form7AboutProgram form7 = new Form7AboutProgram();
            form7.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
                       
        if (AllFieldsFilled())
            {
                var database = new Database();
                if (database.connect_db())
                {
                    // Check if the user with the specified UserID already exists
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE UserID = @UserID";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, database.mySqlConnection);
                    checkCommand.Parameters.AddWithValue("@UserID", AddUserIDTB.Text);

                    int existingUserCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (existingUserCount > 0)
                    {
                        // User already exists
                        MessageBox.Show("User ID already in use!");
                    }
                    else
                    {
                        // User doesn't exist, proceed with insertion
                        string insertQuery = "INSERT INTO users VALUES (@UserID, @FirstName, @LastName, @Specialization, @ContactNum, @Status, @Password, DEFAULT)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.mySqlConnection);

                        insertCommand.Parameters.AddWithValue("@UserID", AddUserIDTB.Text);
                        insertCommand.Parameters.AddWithValue("@FirstName", AddFnameTB.Text);
                        insertCommand.Parameters.AddWithValue("@LastName", AddLnameTB.Text);
                        insertCommand.Parameters.AddWithValue("@Specialization", AddSpecTB.Text);
                        insertCommand.Parameters.AddWithValue("@ContactNum", AddContTB.Text);
                        insertCommand.Parameters.AddWithValue("@Status", AddStatusTB.Text);
                        insertCommand.Parameters.AddWithValue("@Password", AddPassTB.Text);
             

                        try
                        {
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User Successfully Added!");
                                ClearTextboxes();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Add User.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding user: " + ex.Message);
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
            return !string.IsNullOrWhiteSpace(AddUserIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddFnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddLnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddSpecTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddContTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddStatusTB.Text) &&
                   !string.IsNullOrWhiteSpace(AddPassTB.Text);
        }

        private void ClearTextboxes()
        {
            AddUserIDTB.Text = "";
            AddFnameTB.Text = "";
            AddLnameTB.Text = "";
            AddSpecTB.Text = "";
            AddContTB.Text = "";
            AddStatusTB.Text = "";
            AddPassTB.Text = "";
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void PatientsBtn_Click_1(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }
    }
}
