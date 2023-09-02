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
    public partial class AdminForm1 : Form
    {
        public event EventHandler GoBackClicked;

        public AdminForm1()
        {
            InitializeComponent();
        }

 

        private void AdminForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.aircraft' table. You can move, or remove it, as needed.
            this.aircraftTableAdapter1.Fill(this.flightDataSet.aircraft);
            // TODO: This line of code loads data into the 'flight4321DataSet.Aircraft' table. You can move, or remove it, as needed.
          

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

        private void aircraftDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve airport details from the input fields
            string airportModel = aircraftmodel.Text;
            int airportCapacity = Convert.ToInt32(aircraftcapacity.Text);

            // Insert the airport details into the database
            string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO aircraft ([model], [capacity]) VALUES (@model, @capacity)";
                    command.Parameters.AddWithValue("@model", airportModel);
                    command.Parameters.AddWithValue("@capacity", airportCapacity);

                    command.ExecuteNonQuery();
                    MessageBox.Show("aircraft details inserted successfully.");
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
            command.CommandText = "SELECT * FROM aircraft";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            aircraftDataGridView.DataSource = dataTable;

            connection.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            // Retrieve airport details from the input fields
            string airportId = aircraftIdTextBox.Text;
            string airportModel = aircraftmodel.Text;
            int airportCapacity = Convert.ToInt32(aircraftcapacity.Text);

            // Update the airport details in the database
            string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE aircraft SET [model] = @model, [capacity] = @capacity WHERE [id] = @id";
                    command.Parameters.AddWithValue("@model", airportModel);
                    command.Parameters.AddWithValue("@capacity", airportCapacity);
                    command.Parameters.AddWithValue("@id", int.Parse(airportId));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("aircraft details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("aircraft not found or no changes were made.");
                    }
                }
            }
        }
    }
}
