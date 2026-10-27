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
        public MainForm(LoginForm loginForm, Profile profile)
        {
            InitializeComponent();
            _loginForm = loginForm;
            textBoxProfileName.MaxLength = 80;               // server limit
            richTextBoxProfileDecription.MaxLength = 280;    // server limit
            textBoxProfileName.Text = profile.DisplayName;
            richTextBoxProfileDecription.Text = profile.Bio;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                await ApiClient.UpdateProfileAsync(textBoxProfileName.Text, richTextBoxProfileDecription.Text);
                MessageBox.Show("Zapisano");
            }
            catch (ApiException ex) when (ex.Status == System.Net.HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("Sesja wygasła, zaloguj się ponownie.");
                buttonLogOut_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Błąd: " + ex.Message); }
        }

        private async void buttonLogOut_Click(object sender, EventArgs e)
        {
            await ApiClient.LogoutAsync();    // invalidates the session on the server
            _loggingOut = true;
            _loginForm.Show();
            this.Close();
        }

        private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_loggingOut)
            {
                await ApiClient.LogoutAsync();
                Application.Exit();
            }
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
