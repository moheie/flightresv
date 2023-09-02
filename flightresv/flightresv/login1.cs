using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace flightresv
{
    public partial class login1 : Form
    {
        private admin ad;
        private UserForm us;
        public event EventHandler GoBackClicked;
        private const string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";

        public login1()
        {
            InitializeComponent();
            ad = new admin();
            ad.GoBackClicked += admin_GoBackClicked;
            // The UserForm instance will be created when the button is clicked
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox3.Text);
            string password = textBox4.Text;

            string role = AuthenticateUser(id, password);

            if (role == "admin")
            {
                OpenAdminForm();
            }
            else if (role == "customer")
            {
                OpenUserForm(id); // Pass the ID to the UserForm
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                // Display appropriate error message or take necessary action
            }
        }

        private string AuthenticateUser(int id, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT [role] FROM [user] WHERE [id] = @Name AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", id);
                    command.Parameters.AddWithValue("@Password", password);

                    string role = (string)command.ExecuteScalar();
                    return role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        // Remove the OpenUserForm method since we will open it with the user's ID

        private void button4_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenAdminForm()
        {

            ad.Show();
            this.Hide();
        }
        // Add the method to open the UserForm with the ID
        private void OpenUserForm(int id)
        {
            us = new UserForm(id);
            us.GoBackClicked += user_GoBackClicked;
            us.Show();
            this.Hide();
        }

        private void user_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
