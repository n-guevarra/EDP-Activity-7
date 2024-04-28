using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EDP___Hospital_IS
{
    public partial class Form6Reports : Form
    {
        private string dateColumnName; // Variable to store the date column name
        private string tableName;
        //Declare these two variables globally so you can access them from both   
        //Button1 and Button2.
        Excel.Application objApp;   
        Excel._Workbook objBook;

        public Form6Reports()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6Reports form6 = new Form6Reports();
            form6.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form7AboutProgram form7 = new Form7AboutProgram();
            form7.Show();
            this.Close();
        }

        private void Form6Reports_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12).ToArray());
        }

        public void loadData(string tableName, string[] columns)
        {
            var database = new Database();
            if (database.connect_db())
            {
                string columnsString = string.Join(", ", columns);
                string query = $"SELECT {columnsString} FROM {tableName}";

                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                foreach (DataColumn column in dt.Columns)
                {
                    if (column.DataType == typeof(DateTime))
                    {
                        column.DateTimeMode = DataSetDateTime.UnspecifiedLocal;
                    }
                }

                gunaDataGridViewReports.DataSource = bindingSource;

                foreach (DataGridViewColumn column in gunaDataGridViewReports.Columns)
                {
                    if (column.ValueType == typeof(DateTime))
                    {
                        column.DefaultCellStyle.Format = "yyyy-MM-dd"; // or any other desired format
                    }
                }

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database Error!");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = comboBox1.SelectedItem.ToString();
            FilterDataByMonth(tableName, selectedMonth, dateColumnName);
        }

        private void FilterDataByMonth(string tableName, string month, string dateColumnName)
        {
            int monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            string query;
            string[] selectedColumns;

            // Determine selected columns based on the table name and button clicked
            switch (tableName)
            {
                case "patients":
                    selectedColumns = new string[] { "PatientID", "FirstName", "LastName", "AdmissionDate", "DischargeDate" };
                    break;
                case "billing":
                    selectedColumns = new string[] { "BillingID", "PatientID", "AdmissionDate", "DischargeDate", "accommodation_fee" };
                    break;
                case "appointments":
                    selectedColumns = new string[] { "AppointmentID", "PatientID", "UserID", "AppointmentDate", "Department" };
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }

            string columnsString = string.Join(", ", selectedColumns);
            query = $"SELECT {columnsString} FROM {tableName} WHERE MONTH({dateColumnName}) = {monthNumber}";

            loadDataWithQuery(query);
        }



        private void loadDataWithQuery(string query)
        {
            var database = new Database();
            if (database.connect_db())
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                foreach (DataColumn column in dt.Columns)
                {
                    if (column.DataType == typeof(DateTime))
                    {
                        column.DateTimeMode = DataSetDateTime.UnspecifiedLocal;
                    }
                }

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                gunaDataGridViewReports.DataSource = bindingSource;

                foreach (DataGridViewColumn column in gunaDataGridViewReports.Columns)
                {
                    if (column.ValueType == typeof(DateTime))
                    {
                        column.DefaultCellStyle.Format = "yyyy-MM-dd"; // or any other desired format
                    }
                }

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database Error!");
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Form8Users form8 = new Form8Users();
            form8.Show();
            this.Close();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Form5Dashboard form5 = new Form5Dashboard();
            form5.Show();
            this.Close();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            string[] selectedColumns = new string[] { "BillingID", "PatientID", "AdmissionDate", "DischargeDate", "accommodation_fee" };
            loadData("billing", selectedColumns);
            tableName = "billing";
            dateColumnName = "DischargeDate";
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            string[] selectedColumns = new string[] { "PatientID", "FirstName", "LastName", "AdmissionDate", "DischargeDate" };
            loadData("patients", selectedColumns);
            tableName = "patients";
            dateColumnName = "DischargeDate";
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            string[] selectedColumns = new string[] { "AppointmentID", "PatientID", "UserID", "AppointmentDate", "Department" };
            loadData("appointments", selectedColumns);
            tableName = "appointments";
            dateColumnName = "AppointmentDate";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e) // export button
        {
            if (string.IsNullOrWhiteSpace(excelFilePath.Text))
            {
                MessageBox.Show("Please select an Excel template file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedMonth = comboBox1.SelectedItem.ToString();
            ExportToExcel(excelFilePath.Text, selectedMonth);
        }


        private void ExportToExcel(string filePath, string month)
        {
            string newFileName = Path.GetFileNameWithoutExtension(filePath) + "_" + month + "_2024.xlsx";
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);
            File.Copy(filePath, newFilePath);

            // Create an instance of Excel Application
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Open the existing Excel template file
                workbook = excelApp.Workbooks.Open(newFilePath);

                // Access the first worksheet
                worksheet = workbook.Sheets[1];

                FormatDateColumns(worksheet);


                worksheet.Cells[8, 9] = month;

                // Assuming dgvData is your DataGridView
                for (int i = 0; i < gunaDataGridViewReports.Rows.Count; i++)
                {
                    for (int j = 0; j < gunaDataGridViewReports.Columns.Count; j++)
                    {
                        // Fill the Excel cells with DataGridView values
                        worksheet.Cells[i + 10, j + 6] = gunaDataGridViewReports.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save the changes and close Excel
                workbook.Save();
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up resources
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
            }
        }
        private void FormatDateColumns(Excel.Worksheet worksheet) // di ko sure if need mo, yung akin kasi sabog parin naman format ng date HAHA
        {
            // Get the used range of the worksheet
           Excel.Range usedRange = worksheet.UsedRange;

            // Loop through each column in the used range
            foreach (Excel.Range column in usedRange.Columns)
            {
                // Check if any cell in the column contains dates
              bool hasDates = false;
              foreach (Excel.Range cell in column.Cells)
                {
                    if (cell.Value != null && cell.Value is DateTime)
                    {
                       hasDates = true;
                       break;
                    }
                 }

                // If the column contains dates, format it
                if (hasDates)
                {
                    column.NumberFormat = "yyyy-mm-dd";
                }
            }
        }

        // Helper method to release COM objects
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error releasing COM object: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            Form16Patients form16 = new Form16Patients();
            form16.Show();
            this.Close();
        }
    }
}
