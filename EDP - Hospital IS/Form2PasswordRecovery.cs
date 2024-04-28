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
    public partial class Form2PasswordRecovery : Form
    {
        private string placeholderText1 = "Contact Number";
        public Form2PasswordRecovery()
        {
            InitializeComponent();
            InitializeTextBoxEmail();
            
        }
        private void InitializeTextBoxEmail()
        {
            ContactNumTB.Text = placeholderText1;
            ContactNumTB.ForeColor = System.Drawing.Color.Gray;
            ContactNumTB.Padding = new Padding(0, 5, 0, -5);
            ContactNumTB.GotFocus += textBoxEmail_GotFocus;
            ContactNumTB.LostFocus += textBoxEmail_LostFocus;
        }

        private void textBoxEmail_GotFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (textBox.Text == placeholderText1)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxEmail_LostFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBoxEmail = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = placeholderText1;
                textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2PasswordRecovery_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                if (string.IsNullOrWhiteSpace(ContactNumTB.Text))
                {
                    MessageBox.Show("Please enter a valid contact number.");
                    return;
                }

                string contactNumber = ContactNumTB.Text;

                // Check if the contact number exists in the database
                if (CheckContactNumberInDatabase(contactNumber))
                {
                    // Redirect to Form4NewPassword, passing the contact number
                    Form4NewPassword form4 = new Form4NewPassword(contactNumber);
                    form4.ShowDialog(); // Use ShowDialog to make it a modal dialog
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contact number not found. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Database connection failed!");
            }
        }

        private bool CheckContactNumberInDatabase(string contactNumber)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT UserID FROM users WHERE ContactNum = @TargetContactNum";

                MySqlCommand mySqlCommand = new MySqlCommand(query, database.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@TargetContactNum", contactNumber);

                using (MySqlDataReader rdr = mySqlCommand.ExecuteReader())
                {
                    return rdr.HasRows;
                   
                }
            }
            else
            {
                MessageBox.Show("Database connection failed!");
                return false;
            }
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

        private void resetBackbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
