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
    public partial class UserForm : Form
    {
        public event EventHandler GoBackClicked;
        private uud uud;
        private manageuserflights manageuserflights;
        private booking book;

        public UserForm(int id)
        {
            InitializeComponent();

            uud = new uud(id);
            uud.GoBackClicked += uud_GoBackClicked;

           

            manageuserflights = new manageuserflights(id);
            manageuserflights.GoBackClicked += cancel_GoBackClicked;

            book = new booking(id);
            book.GoBackClicked += book_GoBackClicked;
        }

        private void book_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cancel_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cfc_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void uud_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoBackClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSigninForm();
        }

        private void OpenSigninForm()
        {
            uud.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            manageuserflights.Show();
            this.Hide();
        }

     

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
