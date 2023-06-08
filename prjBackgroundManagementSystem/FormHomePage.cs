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

    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }


        Form SaveForm = null;
        public void AddAndCheckForm(Form form)
        {

            if (SaveForm != null)
            {
                SaveForm.Close();
                SaveForm = null;
            }
            form.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(form);
            form.Show();

            SaveForm = form;
        }
        private void btnLoginEmployeeManager_Click(object sender, EventArgs e)
        {
            if (SaveForm != null)
            {
                SaveForm.Close();
                SaveForm = null;
            }
            var loginManager = new FormEmployeeManagerLogin();
            loginManager.SaveFunction = this.AddAndCheckForm;
            loginManager.Owner = this;
            loginManager.ShowDialog();
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            FormMember member = new FormMember();
            AddAndCheckForm(member);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct product = new FormProduct();
            AddAndCheckForm(product);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder order = new FormOrder();
            AddAndCheckForm(order);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            FormCategory category = new FormCategory();
            AddAndCheckForm(category);
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {

                this.Close();
            
        }
        private void FormHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定關閉系統嗎?","提示訊息!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            else
            {
                this.Owner.Show();
            }

        }


    }
}
