using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flightresv
{
    public partial class splash : Form
    {
        private void login_Load(object sender, EventArgs e)
        {

        }
        public splash()
        {
            InitializeComponent();

            // Subscribe to the Load event
            Load += progressBar1_Click;
        }

        private async void progressBar1_Click(object sender, EventArgs e)
        {
            // Define your task or process here
            int totalSteps = 100;

            // Update progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalSteps;
            progressBar1.Value = 0;

            for (int i = 0; i <= totalSteps; i++)
            {
                // Update progress bar
                progressBar1.Value = i;
                await Task.Delay(10); // Delay to simulate a task being performed
            }

            // Progress bar finished loading, open login form and hide splash form
            OpenAdminForm();
        }

        private void OpenAdminForm()
        {
            choose login = new choose();
            login.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
