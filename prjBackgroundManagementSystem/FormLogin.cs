using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            var forget = new FormForgetThePassword();
            forget.Owner = this;
            this.Hide();
            forget.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "tom@gmail.com";
            txtPassword.Text = "123";
        }
    }
}
