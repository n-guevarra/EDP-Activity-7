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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP___Hospital_IS
{
    public partial class Form12NewPassRecov : Form
    {
        public Form12NewPassRecov()
        {
            InitializeComponent();
        }

        private void Form12NewPassRecov_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = new Database();

            if (database.connect_db())
            {
                string selectQuery = "SELECT * FROM users WHERE ContactNum = @TargetContactNumber;";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, database.mySqlConnection);

                selectCommand.Parameters.AddWithValue("@TargetContactNumber", ContactNumTB.Text);

                using (MySqlDataReader rdr = selectCommand.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        // Retrieve user information from the reader
                        string userId = rdr.GetString("UserID"); // Assuming UserID is a string; adjust accordingly
                                                                 // Retrieve other columns as needed

                        rdr.Close(); // Close the DataReader before executing the update command

                        if (newPassTB.Text == RnewPassTB.Text)
                        {
                            string updateQuery = "UPDATE users SET Password = @Password WHERE UserID = @UserID";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.mySqlConnection);

                            updateCommand.Parameters.AddWithValue("@Password", newPassTB.Text);
                            updateCommand.Parameters.AddWithValue("@UserID", userId);

                            try
                            {
                                int rowsAffected = updateCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Password Successfully Changed!");
                                    ClearTextboxes();
                                    Form5Dashboard form5 = new Form5Dashboard();
                                    form5.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to change password.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error changing password: {ex.Message}\nStackTrace: {ex.StackTrace}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match. Please enter the same password in both fields.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified contact number.");
                    }
                }

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error!");
            }
        }


        private void ClearTextboxes()
        {
            // Clear the textboxes after successful password change
            ContactNumTB.Text = "";
            newPassTB.Text = "";
            RnewPassTB.Text = "";
        }




    }
}
