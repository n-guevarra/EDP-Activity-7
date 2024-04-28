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
    public partial class Form4NewPassword : Form
    {
        private string contactNumber;
        public Form4NewPassword(string contactNumber)
        {
            InitializeComponent();
            this.contactNumber = contactNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form4NewPassword_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate and get the new password from the user input
            string newPassword = NewPassTB.Text;
            string repeatPassword = RepeatPassTB.Text;

            // Check if the passwords match
            if (newPassword != repeatPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            // Update the password in the database
            if (UpdatePasswordInDatabase(newPassword))
            {
                MessageBox.Show("Password changed successfully!");
                Form1 form1 = new Form1();
                form1.Show();
                this.Close(); // Close the form after successful password change
            }
            else
            {
                MessageBox.Show("Failed to change the password. Please try again.");
            }
        }

        private bool UpdatePasswordInDatabase(string newPassword)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string updateQuery = "UPDATE users SET Password=@Password WHERE ContactNum=@ContactNum";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, database.mySqlConnection);

                // Use the stored contact number from the constructor
                updateCommand.Parameters.AddWithValue("@ContactNum", this.contactNumber);

                // Always use the hashed or encrypted value of the password for security
                updateCommand.Parameters.AddWithValue("@Password", newPassword);

                try
                {
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true; // Password Reset successful
                    }
                    else
                    {
                        MessageBox.Show("Failed to change password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }
                finally
                {
                    database.mySqlConnection.Close();
                }
            }

            return false;
        }

        private void NewPassTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2PasswordRecovery form2 = new Form2PasswordRecovery();
            form2.Show();
            this.Hide(); // or this.Close();
        }
    }
}
