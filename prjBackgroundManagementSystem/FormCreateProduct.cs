using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
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
    public partial class FormCreateProduct : Form
    {
        public FormCreateProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBoxName.Text;
                if (textBoxName.Text == string.Empty)
                {
                    MessageBox.Show("請輸入商品名稱!");
                    return;
                }
                decimal price = decimal.Parse(textBoxPrice.Text);
                if (price <= 0)
                {
                    MessageBox.Show("請重新輸入商品價格!");
                    return;
                }
                string Description = txtDescription.Text;
                DateTime Added = dateTimePickerAdded.Value;
                DateTime Shelf = dateTimePickerShelf.Value;

                var db = new AppDbContext();

                var productUpdate = new Product()
                {
                    ProductName = Name,
                    Price = price,
                    ProductCategoryId = db.Categories.Where(c => c.CategoryName == comboBoxCategory.Text).Select(c => c.CategoryId).FirstOrDefault(),
                    SupplierId = db.Suppliers.Where(s => s.SupplierName == comboBoxSupplier.Text).Select(s => s.SupplierId).FirstOrDefault(),
                    AddedTime = Added,
                    ShelfTime = Shelf,
                    Description = Description,
                };

                comboBoxCategory.Items.Add(productUpdate);
                comboBoxSupplier.Items.Add(productUpdate);
                db.Products.Add(productUpdate);
                db.SaveChanges();
                MessageBox.Show("新增商品成功!");
                var parent = this.Owner as IGrid;
                if (parent != null)
                {
                    parent.Display();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增成功，請重新刷新頁面。");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入商品價格!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateProduct_Load(object sender, EventArgs e)
        {
            ProductDto Add = new ProductRepository().AddCategry();

            comboBoxCategory.Text = Add.ProductCategoryName;
            List<string> cateData = new ProductRepository().AllMothed();
            foreach (string cate in cateData)
            {
                comboBoxCategory.Items.Add(cate);
            }

            comboBoxSupplier.Text = Add.SupplierId.ToString();
            List<string> supplierData = new ProductRepository().Allsupplier();
            foreach (string supplier in supplierData)
            {
                comboBoxSupplier.Items.Add(supplier);
            }

        }

        private void dateTimePickerAdded_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerShelf.Value < dateTimePickerAdded.Value)
            {
                MessageBox.Show("下架時間的日期必須大於上架的日期");
                dateTimePickerAdded.Value = DateTime.Today;
                dateTimePickerShelf.Value = DateTime.Today;
            }
        }

        private void dateTimePickerShelf_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePickerShelf.Value < dateTimePickerAdded.Value)
            {
                MessageBox.Show("下架時間的日期必須大於上架的日期");
                dateTimePickerAdded.Value = DateTime.Today;
                dateTimePickerShelf.Value = DateTime.Today;
            }
        }
    }
}
