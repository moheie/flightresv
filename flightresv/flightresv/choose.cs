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
    public partial class choose : Form
    {
        private signin signinForm; 
        private login1 login;
        public choose()
        {
            InitializeComponent();
            signinForm = new signin();
            login = new login1();
            login.GoBackClicked += loginForm_GoBackClicked;
            signinForm.GoBackClicked += SigninForm_GoBackClicked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSigninForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenSigninForm()
        {
            signinForm.Show();
            this.Hide();
        }

        private void OpenAdminForm1()
        {
            
            login.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenAdminForm1();
        }
        private void SigninForm_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void loginForm_GoBackClicked(object sender, EventArgs e)
        {
            this.Show();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}