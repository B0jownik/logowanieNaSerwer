using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace ServewerLog_in
{
    public partial class LoginForm : Form
    {
        string email = "a@gmail.com";
        string password = "1234";
        private static readonly HttpClient client = new HttpClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                string odpowiedz = await client.GetStringAsync("https://api.54-36-162-208.sslip.io");
                MessageBox.Show(odpowiedz);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            labelWrongAnnouncer.Text = string.Empty;
            if (textBoxEmail.Text == email && textBoxHaslo.Text == password)
            {
                var main = new MainForm(this);
                main.Show();
                this.Hide();
                ResetTextBoxes();
            }
            else
            {
                labelWrongAnnouncer.Text = "Podany email lub hasło jest niepoprawny";
                ResetTextBoxes();
            }
        }
        private void ResetTextBoxes()
        {
            textBoxEmail.Text = string.Empty;
            textBoxHaslo.Text = string.Empty;
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
