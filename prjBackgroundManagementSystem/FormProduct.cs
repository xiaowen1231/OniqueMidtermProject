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
    public partial class FormProduct : Form, IGrid
    {
        List<ProductDto> data = new List<ProductDto>();
        public FormProduct()
        {
            InitializeComponent();
            this.Load += FormProduct_Load;

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            AllMothed();
            Display();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            int? productId = null;


            string Name = this.textBoxName.Text;
            string category = this.comboBox.Text;


            data = new ProductRepository().Search(productId, Name, category);
            dataGridView1.DataSource = data;
        }

        public void AllMothed()
        {
            List<string> ProductCategoryData = new ProductRepository().AllMothed();
            foreach (string ProductCategory in ProductCategoryData)
            {
                comboBox.Items.Add(ProductCategory);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            comboBox.Text = string.Empty;
            Display();
        }


        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // 按到了header,不處理

            int id = this.data[e.RowIndex].ProductId;

            var frm = new FormEditPorduct(id);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var CreateProduct = new FormCreateProduct();
            CreateProduct.Owner = this;
            CreateProduct.ShowDialog();
        }
    }
}
