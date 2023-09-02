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
    public partial class signin : Form
    {
        public event EventHandler GoBackClicked;

        public signin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=MSI;Initial Catalog=flight;Integrated Security=True");
            sqlconnection.Open();

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlconnection;

                // Check if the username already exists
                command.CommandText = "SELECT COUNT(*) FROM [user] WHERE [name] = @Name";
                command.Parameters.AddWithValue("@Name", usernameTextBox.Text);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else
                {
                    // Insert the new user into the database
                    command.CommandText = "INSERT INTO [user] ([name], [password], [role]) VALUES (@Name, @Password, 'customer')";
                    command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    command.ExecuteNonQuery();

                    // Get the user ID
                    command.CommandText = "SELECT [id] FROM [user] WHERE [name] = @Name2 AND [password] = @Password2";
                    command.Parameters.AddWithValue("@Name2", usernameTextBox.Text);
                    command.Parameters.AddWithValue("@Password2", passwordTextBox.Text);
                    int userID2 = (int)command.ExecuteScalar();

                    // Display the user ID
                    MessageBox.Show("Your ID is: " + userID2);
                }
            }

            sqlconnection.Close();
            sqlconnection.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }
    }
}
