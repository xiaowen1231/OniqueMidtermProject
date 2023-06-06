using Onique.EStore.SqlDataLayer;
using Onique.EStore.SqlDataLayer.EFModels;
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
            var db = new AppDbContext();
            var query = db.Employees.Where(x => x.Email == txtEmail.Text).Select (x=>new EmployeeLoginDto
            {
                Email = x.Email,
                Password = x.Password,
            });

            var result = query.FirstOrDefault();
            
            if (result == null)
            {
                MessageBox.Show("帳號密碼錯誤");
                return;
            }
            if(result != null)
            {
                if (result.Password == txtPassword.Text)
                {
                    var frm = new FormHomePage();
                    frm.Owner = this;
                    this.Hide();
                    frm.Show();
                    txtEmail.Text = "";
                    txtPassword.Text = "";

                }
                else 
                {
                    MessageBox.Show("帳號密碼錯誤");
                    return;
                }
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            var forget = new FormForgetThePassword();
            forget.Owner = this;
            this.Hide();
            forget.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "tom@gmail.com";
            txtPassword.Text = "123";
        }
    }
}
