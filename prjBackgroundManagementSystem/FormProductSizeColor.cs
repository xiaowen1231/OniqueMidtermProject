using Onique.EStore.SqlDataLayer.EFModels;
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
    public partial class FormProductSizeColor : Form
    {
        private readonly int _id;
        public FormProductSizeColor(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormProductSizeColor_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var Size = db.ProductSizes.Where(ps => ps.SizeId == ps.SizeId).Select(ps => ps.SizeName).ToArray();
            comboBoxSize.Items.AddRange(Size.ToArray());

            txtProductName.Text = db.Products.Where(p => p.ProductId == _id).Select(p => p.ProductName).FirstOrDefault();

            var Color = db.ProductColors.Where(pc => pc.ColorId == pc.ColorId).Select(pc => pc.ColorName).ToArray();
            comboBoxColor.Items.AddRange(Color.ToArray());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSettingProductStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(comboBoxSize.Text)
                || string.IsNullOrEmpty(comboBoxColor.Text))
            {
                MessageBox.Show("請完整填寫資料");
                return;
            }
            var db = new AppDbContext();

            int productId = db.Products.Where(p => p.ProductName == txtProductName.Text)
                .Select(p => p.ProductId)
                .FirstOrDefault();

            int colorId = db.ProductColors.Where(p => p.ColorName == comboBoxColor.Text)
                .Select(p => p.ColorId)
                .FirstOrDefault();

            int sizeId = db.ProductSizes.Where(p => p.SizeName == comboBoxSize.Text)
                .Select(p => p.SizeId)
                .FirstOrDefault();

            var stockInDb = db.ProductStockDetails
                .Where(psd => psd.ProductId == productId
                && psd.ColorId == colorId
                && psd.SizeId == sizeId).ToList();

            if (stockInDb.Count != 0)
            {
                MessageBox.Show("此商品庫存已存在!可直接至庫存設定頁面變更庫存!");
                return;
            }

            var productStockDetail = new ProductStockDetail
            {
                ProductId = productId,
                SizeId = sizeId,
                ColorId = colorId,
                Quantity = 0
            };

            db.ProductStockDetails.Add(productStockDetail);
            db.SaveChanges();
            MessageBox.Show("新增庫存設定成功!");
            this.Close();
        }
    }
}
