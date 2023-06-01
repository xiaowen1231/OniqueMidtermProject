using Onique.EStore.SqlDataLayer;
using Onique.EStore.SqlDataLayer.EFModels;
using prjBackgroundManagementSystem.Delegate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prjBackgroundManagementSystem.FormHomePage;

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
            forgetManagerPassword.Show();
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
            var db = new AppDbContext();
            var query = db.Employees.Where(x => x.Email == txtMangerEmail.Text && x.Position == "經理" )
                .Select(x => new EmployeeManagerLoginDto
                {
                    Email = x.Email,
                    Password = x.Password,
                    Position = x.Position
                });
            var result = query.FirstOrDefault();
            if( result == null)
            {
                MessageBox.Show("帳號密碼錯誤");
                return;
            }
            if( result != null )
            {
                if(result.Password ==  txtMangerPassword.Text )
                {
                    var frmEmployee = new FormEmployee();

                   SaveFunction( frmEmployee );
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤");
                }
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtMangerEmail.Text = "hendy@gmail.com";
            txtMangerPassword.Text = "123";
        }
    }
}
