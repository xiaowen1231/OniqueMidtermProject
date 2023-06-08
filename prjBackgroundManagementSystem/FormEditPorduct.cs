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
    public partial class FormEditPorduct : Form
    {
        private readonly int _id;
        public FormEditPorduct(int id)
        {
            this._id = id;
            InitializeComponent();
        }

        private void FormEditPorduct_Load(object sender, EventArgs e)
        {
            ProductDto dto = new ProductRepository().EditCategory(_id);

            txtProductName.Text = dto.ProductName;
            txtPrice.Text = dto.Price.ToString("0");
            txtDescription.Text = dto.Description;
            dateTimePickerAdded.Text = dto.AddedTime.ToString();
            dateTimePickerShelf.Text = dto.ShelfTime.ToString();

            comboBoxCategory.Text = dto.ProductCategoryName;
            List<string> cateData = new ProductRepository().AllMothed();
            foreach (string cate in cateData)
            {
                comboBoxCategory.Items.Add(cate);
            }

            comboBoxSupplier.Text = dto.SupplierId.ToString();
            List<string> supplierData = new ProductRepository().Allsupplier();
            foreach (string supplier in supplierData)
            {
                comboBoxSupplier.Items.Add(supplier);
            }


        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new AppDbContext();

                var Update = db.Products.FirstOrDefault(p => p.ProductId == _id);
                if (int.Parse(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("請重新輸入商品價格!");
                    txtPrice.Clear();
                    return;
                }
                if (Update != null)
                {
                    Update.Description = txtDescription.Text;
                    Update.Price = int.Parse(txtPrice.Text);
                    Update.AddedTime = dateTimePickerAdded.Value;
                    Update.ShelfTime = dateTimePickerShelf.Value;
                    db.SaveChanges();
                    MessageBox.Show("編輯商品成功");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("請確認商品資訊是否有誤!");
                txtPrice.Clear();
            }
        }

        private void buttonStockSet_Click(object sender, EventArgs e)
        {
            var frm = new FormProductStockDetails(_id);
            frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();

            var delete = db.Products.FirstOrDefault(p => p.ProductId == _id);
            try
            {
                if (delete != null)
                {
                    db.Products.Remove(delete);
                    db.SaveChanges();
                    MessageBox.Show("刪除商品成功!");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("此商品在庫存設定中已有資料，請先清空庫存設定!");
                return;
            }

        }

        private void buttonSizeColor_Click(object sender, EventArgs e)
        {
            FormProductSizeColor frm = new FormProductSizeColor(_id);
            frm.ShowDialog();
        }



        private void buttonSize_Click(object sender, EventArgs e)
        {
            FormCreateSize frm = new FormCreateSize(_id);
            frm.ShowDialog();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            FormCreateColor frm = new FormCreateColor(_id);
            frm.ShowDialog();
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
