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
            int? orderId = null;
            if (int.TryParse(textBoxOrderId.Text, out int number))
            {
                orderId = number;
            }
            string orderStatus = comboBoxOrderStatus.Text;

            data = new OrderRepository().Search(orderId, orderStatus);

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
    }
}
