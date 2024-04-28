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
    public partial class Form10Edit : Form
    {
      
        public Form10Edit()
        {
            InitializeComponent();
        }

        public void SetUserValues(string userId, string firstName, string lastName, string specialization, string contactNum, string status, string password, string accstat)
        {
            EditUserIDTB.Text = userId;
            EditFnameTB.Text = firstName;
            EditLnameTB.Text = lastName;
            EditSpecTB.Text = specialization;
            EditContTB.Text = contactNum;
            EditStatusTB.Text = status;
            EditPassTB.Text = password;
            EditAccStatTB.Text = accstat;
     
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void Form10Edit_Load(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                var database = new Database();
                if (database.connect_db())
                {
                    string insertQuery = "UPDATE users SET userId=@UserID, firstName=@FirstName, lastName=@LastName, specialization=@Specialization, contactNum=@ContactNum, status=@Status, password=@Password, AccountStatus=@AccountStatus WHERE userID=@UserID";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, database.mySqlConnection);
                    
                    insertCommand.Parameters.AddWithValue("@UserID", EditUserIDTB.Text);
                    insertCommand.Parameters.AddWithValue("@FirstName", EditFnameTB.Text);
                    insertCommand.Parameters.AddWithValue("@LastName", EditLnameTB.Text);
                    insertCommand.Parameters.AddWithValue("@Specialization", EditSpecTB.Text);
                    insertCommand.Parameters.AddWithValue("@ContactNum", EditContTB.Text);
                    insertCommand.Parameters.AddWithValue("@Status", EditStatusTB.Text);
                    insertCommand.Parameters.AddWithValue("@Password", EditPassTB.Text);
                    insertCommand.Parameters.AddWithValue("@AccountStatus", EditAccStatTB.Text);

                    try
                    {
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User Successfully Updated!");
                            ClearTextboxes();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Update User.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating user: {ex.Message}\nStackTrace: {ex.StackTrace}");
                    }
                }

                database.close_db(); 
            }
       
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private bool AllFieldsFilled()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(EditUserIDTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditFnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditLnameTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditSpecTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditContTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditStatusTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditPassTB.Text) &&
                   !string.IsNullOrWhiteSpace(EditAccStatTB.Text);
        }

        private void ClearTextboxes()
        {
            EditUserIDTB.Text = "";
            EditFnameTB.Text = "";
            EditLnameTB.Text = "";
            EditSpecTB.Text = "";
            EditContTB.Text = "";
            EditStatusTB.Text = "";
            EditPassTB.Text = "";
            EditAccStatTB.Text = "";
        }

        private void EditAccStatTB_TextChanged(object sender, EventArgs e)
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

        private void EditUserlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
