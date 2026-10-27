using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;

namespace ServewerLog_in
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonFinish_Click(object sender, EventArgs e)
        {
            labelWrongAnnouncer.Text = string.Empty;
            buttonFinish.Enabled = false;
            try
            {
                var profile = await ApiClient.LoginAsync(textBoxEmail.Text.Trim(), textBoxHaslo.Text);
                new MainForm(this, profile).Show();
                this.Hide();
            }
            catch (ApiException ex) when (ex.Status == HttpStatusCode.Unauthorized)
            {
                labelWrongAnnouncer.Text = "Podany email lub hasło jest niepoprawny";
            }
            catch (Exception)
            {
                labelWrongAnnouncer.Text = "Brak połączenia z serwerem";
            }
            finally
            {
                ResetTextBoxes();
                buttonFinish.Enabled = true;
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
