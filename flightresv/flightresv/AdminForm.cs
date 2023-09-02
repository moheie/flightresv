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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flightresv
{
    public partial class AdminForm : Form
    {
        public event EventHandler GoBackClicked;
        public AdminForm()
        {
            InitializeComponent();
        }
  
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.aircraft' table. You can move, or remove it, as needed.
            this.aircraftTableAdapter1.Fill(this.flightDataSet.aircraft);
            // TODO: This line of code loads data into the 'flightDataSet.airport' table. You can move, or remove it, as needed.
            this.airportTableAdapter1.Fill(this.flightDataSet.airport);




        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=flight;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Convert DateTimePicker values to strings
            string departureDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string arrivalDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // Check if a record with the same flight details already exists
            command.CommandText = "SELECT COUNT(*) FROM flight WHERE [origin] = @origin AND [destination] = @destination AND [departure_date] = @departureDate AND [arrival_date] = @arrivalDate AND [aircraft_id] = @aircraftId";
            command.Parameters.AddWithValue("@origin", comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@destination", comboBox2.SelectedValue);
            command.Parameters.AddWithValue("@departureDate", departureDate);
            command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            command.Parameters.AddWithValue("@aircraftId", comboBox3.SelectedValue);

            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Duplicate flight details found. Insert operation canceled.");
                connection.Close();
                return;
            }

            // No duplicates found, perform the insert operation
            command.CommandText = "INSERT INTO flight ([origin], [destination], [departure_date], [arrival_date], [aircraft_id]) VALUES (@origin, @destination, @departureDate, @arrivalDate, @aircraftId)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@origin", comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@destination", comboBox2.SelectedValue);
            command.Parameters.AddWithValue("@departureDate", departureDate);
            command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
            command.Parameters.AddWithValue("@aircraftId", comboBox3.SelectedValue);

            command.ExecuteNonQuery();
            connection.Close();
        }









        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=flight;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            // Retrieve data from the flight and airport tables
            command.CommandText = "SELECT flight.id AS flightID, originAirport.name AS origin, destinationAirport.name AS destination, flight.departure_date, flight.arrival_date, aircraft.model AS aircraftName \r\nFROM flight \r\nINNER JOIN airport AS originAirport ON originAirport.id = flight.origin \r\nINNER JOIN airport AS destinationAirport ON destinationAirport.id = flight.destination \r\nINNER JOIN aircraft ON aircraft.id = flight.aircraft_id";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the dataGridView1
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }











        private void button4_Click(object sender, EventArgs e)
        {
            // Retrieve the flight details from the input fields
            string flightId = flightIdTextBox.Text;
            int origin = Convert.ToInt32(comboBox1.SelectedValue);
            int destination = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime departureDate = dateTimePicker1.Value;
            DateTime arrivalDate = dateTimePicker2.Value;
            int aircraftId = Convert.ToInt32(comboBox3.SelectedValue);

            // Update the flight details in the database
            string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE flight SET [origin] = @origin, [destination] = @destination, [departure_date] = @departureDate, [arrival_date] = @arrivalDate, [aircraft_id] = @aircraftId WHERE [id] = @flightId";
                    command.Parameters.AddWithValue("@origin", origin);
                    command.Parameters.AddWithValue("@destination", destination);
                    command.Parameters.AddWithValue("@departureDate", departureDate);
                    command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                    command.Parameters.AddWithValue("@aircraftId", aircraftId);
                    command.Parameters.AddWithValue("@flightId", int.Parse(flightId));

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Flight details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Flight not found or no changes were made.");
                    }
                }
            }
        }




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
