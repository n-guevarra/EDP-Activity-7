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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EDP___Hospital_IS
{
    public partial class Form1 : Form
    {
        private string placeholderText1 = "Username";
        private string placeholderText2 = "Password";
        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxUn();
            InitializeTextBoxPass();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label label = (Label)sender;
            TextRenderer.DrawText(e.Graphics, label.Text, label.Font, label.ClientRectangle, label.ForeColor, TextFormatFlags.WordBreak);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void InitializeTextBoxUn()
        {
            textBoxUn.Text = placeholderText1;
            textBoxUn.ForeColor = System.Drawing.Color.Gray;
            textBoxUn.Padding = new Padding(0, 5, 0, -5);    
            textBoxUn.GotFocus += textBoxUn_GotFocus;
            textBoxUn.LostFocus += textBoxUn_LostFocus;
        }

        private void textBoxUn_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == placeholderText1)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxUn_LostFocus(object sender, EventArgs e)
        {
            TextBox textBoxUn = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxUn.Text))
            {
                textBoxUn.Text = placeholderText1;
                textBoxUn.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeTextBoxPass()
        {
            textBoxPass.Text = placeholderText2;
            textBoxPass.ForeColor = System.Drawing.Color.Gray;
            textBoxPass.GotFocus += textBoxPass_GotFocus;
            textBoxPass.LostFocus += textBoxPass_LostFocus;
        }

        private void textBoxPass_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == placeholderText2)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxPass_LostFocus(object sender, EventArgs e)
        {
            TextBox textBoxUn = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                textBoxPass.Text = placeholderText2;
                textBoxPass.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2PasswordRecovery form2 = new Form2PasswordRecovery();
            form2.Show();
            this.Hide(); // or this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT UserID, Password FROM users WHERE UserID = @UserID AND Password = @Password AND AccountStatus = @AccountStatus";
                MySqlCommand mySqlcommand = new MySqlCommand(query);
                mySqlcommand.Connection = database.mySqlConnection;

                mySqlcommand.Parameters.AddWithValue("@UserID", textBoxUn.Text);
                mySqlcommand.Parameters.AddWithValue("@Password", textBoxPass.Text);
                mySqlcommand.Parameters.AddWithValue("@AccountStatus", "ACTIVE"); // Set the desired account status

                using (MySqlDataReader rdr = mySqlcommand.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        rdr.Close(); // Close the initial reader

                        // Fetch the user's FirstName
                        string firstNameQuery = "SELECT FirstName FROM users WHERE UserID = @UserID";
                        MySqlCommand firstNameCommand = new MySqlCommand(firstNameQuery, database.mySqlConnection);
                        firstNameCommand.Parameters.AddWithValue("@UserID", textBoxUn.Text);

                        using (MySqlDataReader firstNameReader = firstNameCommand.ExecuteReader())
                        {
                            if (firstNameReader.Read())
                            {
                                string firstName = firstNameReader["FirstName"].ToString();

                                // Open the next form and pass the FirstName
                                Form5Dashboard form5 = new Form5Dashboard();
                                form5.SetFirstName(firstName);
                                form5.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        // Check if the username and password are correct
                        rdr.Close(); // Close the initial reader

                        string inactiveAccountQuery = "SELECT UserID FROM users WHERE UserID = @UserID AND AccountStatus = 'INACTIVE'";
                        MySqlCommand inactiveAccountCommand = new MySqlCommand(inactiveAccountQuery, database.mySqlConnection);
                        inactiveAccountCommand.Parameters.AddWithValue("@UserID", textBoxUn.Text);

                        using (MySqlDataReader inactiveAccountReader = inactiveAccountCommand.ExecuteReader())
                        {
                            if (inactiveAccountReader.HasRows)
                            {
                                // Account is inactive, contact the admin
                                MessageBox.Show("Login Failed: Your account is inactive. Please contact the admin.");
                            }
                            else
                            {
                                // Username or password incorrect
                                MessageBox.Show("Login Failed: Username or Password incorrect");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Database error!");
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
