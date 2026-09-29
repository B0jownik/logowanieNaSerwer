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
    }
}
