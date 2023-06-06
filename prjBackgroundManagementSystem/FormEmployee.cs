using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.Repositoties;
using prjBackgroundManagementSystem.interfaces;
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
    public partial class FormEmployee : Form, IGrid
    {
        private List<EmployeeDto> data;
        public FormEmployee()
        {
            InitializeComponent();
            this.Load += FormEmployee_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            string name = txtEmployeeName.Text;

            data = new EmployeeRepository().Search(name, null);

            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // 按到了header,不處理

            int EmployeeId = this.data[e.RowIndex].EmployeeId;

            var frm = new FormEditEmployee(EmployeeId);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateEmployee();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
