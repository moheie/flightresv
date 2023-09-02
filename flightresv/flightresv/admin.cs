using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightresv
{
    public partial class admin : Form
    {
        private AdminForm login1;
        private AdminForm1 login2;
        private AdminForm2 login3;
        private flightreport login4;
        public event EventHandler GoBackClicked;
        public admin()
        {
            InitializeComponent();
            login1 = new AdminForm();
            login1.GoBackClicked += AdminForm_GoBackClicked;
            login2 = new AdminForm1();
            login2.GoBackClicked += AdminForm1_GoBackClicked;
            login3 = new AdminForm2();
            login3.GoBackClicked += AdminForm2_GoBackClicked;
            login4 = new flightreport();
            login4.GoBackClicked += flightreport_GoBackClicked;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            login2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            login1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            login3.Show();
            this.Hide();
        }
        private void AdminForm_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void AdminForm1_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void AdminForm2_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void flightreport_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login4.Show();
            this.Hide();
        }
    }
}
