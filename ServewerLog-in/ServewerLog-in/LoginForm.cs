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
    public partial class LoginForm : Form
    {
        string email = "a@gmail.com";
        string password = "1234";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            labelWrongAnnouncer.Text = string.Empty;
            if (textBoxEmail.Text == email && textBoxHaslo.Text == password)
            {
                var main = new MainForm(this);
                main.Show();
                this.Hide();
            }
            else
            {
                labelWrongAnnouncer.Text = "Podany email lub hasło jest niepoprawny";
            }
        }







        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMaximise_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal;   }
            else { this.WindowState = FormWindowState.Maximized; }
        }

        private void pictureBoxMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
