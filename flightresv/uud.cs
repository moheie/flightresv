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
    public partial class uud : Form
    {
        public event EventHandler GoBackClicked;
        private int iduser;

        public uud(int id)
        {
            this.iduser = id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void uud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = namee.Text;
            string newPassword = newPassworde.Text;
            string connectionString = "Data Source=MSI;Initial Catalog=flight;Integrated Security=True";
            string query = "UPDATE [user] SET [name] = @name, [password] = @newPassword WHERE [id] = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@id", iduser);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes were made.");
                    }
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void namee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
