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
    public partial class flightreport : Form
    {
        public event EventHandler GoBackClicked;
        
        public flightreport()
        {
            InitializeComponent();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flightreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightDataSet.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.flightDataSet.flight);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
