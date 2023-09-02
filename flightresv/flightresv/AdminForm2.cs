using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightresv
{
    public partial class AdminForm2 : Form
    {
        public event EventHandler GoBackClicked;

        public AdminForm2()
        {
            InitializeComponent();
        }



        private void AdminForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.airport' table. You can move, or remove it, as needed.
            this.airportTableAdapter1.Fill(this.flightDataSet.airport);
            // TODO: This line of code loads data into the 'flight4321DataSet.Airport' table. You can move, or remove it, as needed.
         

        }

   
     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=flight;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Retrieve airport details from the input fields
            string airportName = airportNameTextBox.Text;
            string airportCity = airportCityTextBox.Text;
            string airportCountry = airportCountryTextBox.Text;

            // Check if a record with the same airport name already exists
            command.CommandText = "SELECT COUNT(*) FROM airport WHERE [name] = @name";
            command.Parameters.AddWithValue("@name", airportName);

            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Airport with the same name already exists. Insert operation canceled.");
                connection.Close();
                return;
            }

            // No duplicates found, perform the insert operation
            command.CommandText = "INSERT INTO airport ([name], [city], [country]) VALUES (@name, @city, @country)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@name", airportName);
            command.Parameters.AddWithValue("@city", airportCity);
            command.Parameters.AddWithValue("@country", airportCountry);

            command.ExecuteNonQuery();
            connection.Close();
        }
 



        private void update_Click(object sender, EventArgs e)
        {
            // Retrieve airport details from the input fields
            string airportId = airportIdTextBox.Text;
            string airportName = airportNameTextBox.Text;
            string airportCity = airportCityTextBox.Text;
            string airportCountry = airportCountryTextBox.Text;

            // Update the airport details in the database
            string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE airport SET [name] = @name, [city] = @city, [country] = @country WHERE [id] = @id";
                    command.Parameters.AddWithValue("@name", airportName);
                    command.Parameters.AddWithValue("@city", airportCity);
                    command.Parameters.AddWithValue("@country", airportCountry);
                    command.Parameters.AddWithValue("@id", int.Parse(airportId));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Airport details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Airport not found or no changes were made.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=flight;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Retrieve data from the airport table
            command.CommandText = "SELECT * FROM airport";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            airportDataGridView.DataSource = dataTable;

            connection.Close();
        }
    }
}
