using Onique.EStore.SqlDataLayer;
using Onique.EStore.SqlDataLayer.EFModels;
using prjBackgroundManagementSystem.Delegate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormEmployeeManagerLogin : Form
    {
        public SaveFunction SaveFunction;

        public FormEmployeeManagerLogin()
        {
            InitializeComponent();
        }

        private void btnForgetManager_Click(object sender, EventArgs e)
        {
            var forgetManagerPassword = new FormEmployeeManagerForgetThePassword();
            forgetManagerPassword.Owner = this;
            this.Hide();
            forgetManagerPassword.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormEmployeeManagerLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnLoginManager_Click(object sender, EventArgs e)
        {

        }

        private void btnDemo_Click(object sender, EventArgs e)
        {

        }
    }
}
