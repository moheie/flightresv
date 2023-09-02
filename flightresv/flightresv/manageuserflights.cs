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
    public partial class manageuserflights : Form
    {
        public event EventHandler GoBackClicked;
        private int userid;
        
        private const string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";
        public manageuserflights(int id)
        {
            userid = id;
            InitializeComponent();
            comboBox1.Items.Add("economy");
            comboBox1.Items.Add("business");
            comboBox1.Items.Add("first");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

    

        private void canceling_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
                string query = "select * from [dbo].[booking] where [user_id] = "+userid+"";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       

                        // Set the SqlDataAdapter object
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        // Define dataset
                        DataSet dataSet = new DataSet();

                        dataAdapter.Fill(dataSet);

                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedClass = comboBox1.SelectedItem.ToString();
                string query = "UPDATE [dbo].[booking] SET [class] = @Class WHERE [user_id] = @UserId AND [flight_id] = @FlightId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Class", selectedClass);
                        command.Parameters.AddWithValue("@UserId", userid);
                        command.Parameters.AddWithValue("@FlightId", int.Parse(textBox1.Text));

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Flight class updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the flight class.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                try
                {
                
                    string query = "delete from [dbo].[booking] Where [user_id] = @UserId AND [flight_id] = @FlightId ";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                           
                            command.Parameters.AddWithValue("@UserId", userid);
                            command.Parameters.AddWithValue("@FlightId", int.Parse(textBox1.Text));

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("canceled successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to cancel the flight.");
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
