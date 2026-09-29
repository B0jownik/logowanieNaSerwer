using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServewerLog_in
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;
        private bool _loggingOut = false;
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loggingOut = true;
            _loginForm.Show();
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_loggingOut)
                Application.Exit();
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMaximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal; }
            else { this.WindowState = FormWindowState.Maximized; }
        }

        private void pictureBoxMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
