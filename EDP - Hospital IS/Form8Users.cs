using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP___Hospital_IS
{
    public partial class Form8Users : Form
    {
        private string placeholderTextSearch = "Search";
        public Form8Users()
        {
            InitializeComponent();
            InitializeSearchBox();
            ConfigureDataGridView(gunaGridViewAllUsers);
            gunaGridViewAllUsers.CellContentClick += gunaGridViewAllDoctors_CellContentClick;
            SearchBox.TextChanged += SearchBox_TextChanged;
        }
        
        private void Form8Doctors_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData() 
        {
            var database = new Database(); 
            if (database.connect_db())
            {
                string query = "SELECT * FROM users";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                gunaGridViewAllUsers.DataSource = bindingSource;  
                
                database.close_db();
            }
            else 
            {
                MessageBox.Show("Databse Error!");
            }
        }
        private void gunaGridViewAllDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaGridViewAllUsers.Columns[e.ColumnIndex].Name == "C1EditUser")
            {
                
                    // Get the selected user's details from the DataGridView
                    string userId = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
                    string firstName = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                    string lastName = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                    string specialization = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["Specialization"].Value.ToString();
                    string contactNum = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["ContactNum"].Value.ToString();
                    string status = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                    string password = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                    string accstat = gunaGridViewAllUsers.Rows[e.RowIndex].Cells["AccountStatus"].Value.ToString();

                    Form10Edit editForm = new Form10Edit(); 
                    editForm.SetUserValues(userId, firstName, lastName, specialization, contactNum, status, password, accstat);
                    editForm.ShowDialog();

                   
                
            }
        }
        private void ConfigureDataGridView(GunaDataGridView gunaGridViewAllDoctor)
        {
            // FIX
            foreach (DataGridViewColumn column in gunaGridViewAllDoctor.Columns)
            {
                int textLength = TextRenderer.MeasureText(column.HeaderText, gunaGridViewAllDoctor.Font).Width;
                column.Width = textLength + 20; // Adjust the padding as needed
            }

            gunaGridViewAllDoctor.AllowUserToResizeRows = false; // Disable row resizing

            
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


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
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

        private void gunaAddBtn_Click(object sender, EventArgs e)
        {
            Form9Add form9 = new Form9Add();
            form9.Show();
            this.Close();
        }

        private void gunaGridViewAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var database = new Database();

            if (database.connect_db())
            {
                string searchTerm = SearchBox.Text.Trim();
                string query = "SELECT * FROM users WHERE CONCAT(UserID, FirstName, LastName, Specialization, ContactNum, Status, Password, AccountStatus) LIKE @SearchTerm";

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
                            gunaGridViewAllUsers.DataSource = dataTable;
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


        private void textBox1_TextChanged(object sender, EventArgs e)
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
