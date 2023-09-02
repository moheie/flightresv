using System;
using System.Collections;
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
    public partial class booking : Form
    {
        public event EventHandler GoBackClicked;
        private int userid;
        private const string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";
        public booking(int id)
        {
            this.userid = id;
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.airport' table. You can move, or remove it, as needed.
            this.airportTableAdapter.Fill(this.flightDataSet.airport);
            // TODO: This line of code loads data into the 'flightDataSet.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.flightDataSet.flight);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView originAirport = (DataRowView)originComboBox.SelectedItem;
            DataRowView destinationAirport = (DataRowView)destComboBox.SelectedItem;
            DateTime departureDate = dateTimePicker1.Value.Date; // Use .Date property to ignore the time portion
            string query = "SELECT f.id as flightID, a1.name AS origin, a2.name AS destination, f.departure_date AS departureDate, f.arrival_date AS arrivalDate FROM flight f INNER JOIN airport a1 ON a1.id = f.origin INNER JOIN airport a2 ON a2.id = f.destination WHERE f.origin = @origin AND f.destination = @destination AND CONVERT(DATE, f.departure_date) = @departureDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@origin", originAirport["id"]);
                    command.Parameters.AddWithValue("@destination", destinationAirport["id"]);
                    command.Parameters.AddWithValue("@departureDate", departureDate);

                    // Set the SqlDataAdapter object
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Define dataset
                    DataSet dataSet = new DataSet();

                    dataAdapter.Fill(dataSet);

                    flightDataGrid.DataSource = dataSet.Tables[0];
                }
            }
        }




        private void originComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        connection.Open();

                        command.CommandText = "INSERT INTO [dbo].[booking] VALUES (@UserId, @FlightId, 'economy')";
                        command.Parameters.AddWithValue("@UserId", userid);
                        command.Parameters.AddWithValue("@FlightId", int.Parse(textBox1.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight booked successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to book the flight.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
