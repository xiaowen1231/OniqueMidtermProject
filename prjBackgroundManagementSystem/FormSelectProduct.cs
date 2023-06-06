using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using prjBackgroundManagementSystem.Delegate;
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
    public partial class FormSelectProduct : Form
    {
        List<SelectProductDto> data;
        private readonly int _orderId;
        public FormSelectProduct(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void FormSelectProduct_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            
            string name = textBoxName.Text;
            string category = comboBoxCategory.Text;

            var repo = new OrderRepository();

            data = repo.ProductList(name, category);

            dataGridView1.DataSource = data;

            List<string> items = repo.GetAllItems<Category>(x => x.CategoryName);
            comboBoxCategory.Items.AddRange(items.ToArray());
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int productId = this.data[e.RowIndex].Id;
            
            ((FormAddOrderProduct)Owner).id = productId;

            var parent = this.Owner as IGrid;
            if (parent != null)
            {
                parent.Display();
            }
            this.Close();
          
        }
    }
}
