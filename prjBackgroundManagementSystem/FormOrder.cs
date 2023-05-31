using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
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
    public partial class FormOrder : Form
    {
        List<OrderDto> data = new List<OrderDto>();

        public FormOrder()
        {
            InitializeComponent();

        }

        public void Display()
        {
            labelHint.Visible = false;

            int? orderId = null;

            if (int.TryParse(textBoxOrderId.Text, out int number))
            {
                orderId = number;
            }

            string orderStatus = comboBoxOrderStatus.Text;

            data = new OrderRepository().Search(orderId, orderStatus);

            if (data.Count <= 0)
            {
                labelHint.Visible = true;
            }

            dataGridView1.DataSource = data;

        }

        public void AllStatus()
        {
            List<string> statusData = new OrderRepository().AllStatus();

            foreach (string status in statusData)
            {
                comboBoxOrderStatus.Items.Add(status);
            }

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            AllStatus();
            Display();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void comboBoxOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxOrderId.Text = string.Empty;
            comboBoxOrderStatus.Text = string.Empty;
            dataGridView1.DataSource = new List<OrderDto>();
        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
           data = new OrderRepository().Search(null, null);
           dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0) return;

            int id = this.data[e.RowIndex].Id;

            var frm = new FormOrderDetail(id);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateOrder();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
