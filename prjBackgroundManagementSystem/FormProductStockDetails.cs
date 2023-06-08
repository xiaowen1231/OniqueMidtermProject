using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormProductStockDetails : Form
    {
        private readonly int _id;
        public FormProductStockDetails(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void FormProductStockDetails_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            txtProductName.Text = db.Products.Where(p => p.ProductId == _id).Select(p => p.ProductName).FirstOrDefault();

            var color = (from psd in db.ProductStockDetails
                         join ps in db.ProductSizes on psd.SizeId equals ps.SizeId
                         join p in db.Products on psd.ProductId equals p.ProductId
                         join pc in db.ProductColors on psd.ColorId equals pc.ColorId
                         where p.ProductId == _id
                         group pc by pc.ColorName into g
                         select g.Key)
                         ;
            comboBoxColor.Items.AddRange(color.ToArray());

            var size = (from psd in db.ProductStockDetails
                        join ps in db.ProductSizes on psd.SizeId equals ps.SizeId
                        join p in db.Products on psd.ProductId equals p.ProductId
                        join pc in db.ProductColors on psd.ColorId equals pc.ColorId
                        where p.ProductId == _id
                        group ps by ps.SizeName into g
                        select g.Key);
            comboBoxSize.Items.AddRange(size.ToArray());


        }

        public void DisplayQuantity()
        {
            if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
            {
                var db = new AppDbContext();
                int colorId = db.ProductColors.Where(pc => pc.ColorName == comboBoxColor.Text).Select(pc => pc.ColorId).FirstOrDefault();
                int sizeId = db.ProductSizes.Where(pc => pc.SizeName == comboBoxSize.Text).Select(pc => pc.SizeId).FirstOrDefault();
                int Quantity = db.ProductStockDetails.Where(psd => psd.ColorId == colorId && psd.ProductId == _id && psd.SizeId == sizeId)
                    .Select(psd => psd.Quantity).FirstOrDefault();
                labelHint.Text = "庫存數量:" + Quantity;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSize_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {

        }

        public string DisplayProductPhoto()
        {
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
                && psd.SizeId == sizeId).FirstOrDefault();

            if (stockInDb == null)
            {
                throw new Exception(" 查無此庫存設定");

                //MessageBox.Show("無法顯示商品照片!");
                //return;
            }
            else if (stockInDb != null && stockInDb.ProductPhoto == null)
            {
                return "商品照片/defaultProductPhoto.jpg";
                //MessageBox.Show("此商品尚未設定照片");
                //return;
            }
            else
            {
                var photoPath = db.ProductPhotos.Where(pp => pp.ProductPhotoId == stockInDb.ProductPhotoId)
                    .Select(pp => pp.ProductPhotoPath).FirstOrDefault();
                return photoPath;
            }
        }

        private void buttonEditProductPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
