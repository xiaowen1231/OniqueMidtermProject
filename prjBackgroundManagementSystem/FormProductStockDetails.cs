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
            else
            {
                labelHint.Text = "庫存數量:";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxColor_SelectedValueChanged(object sender, EventArgs e)
        {

            DisplayQuantity();
            if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
            {
                try
                {
                    string photoPath = DisplayProductPhoto();
                    FileStream fs = File.OpenRead(photoPath);
                    pictureBoxProductPhoto.Image = Image.FromStream(fs);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("異常狀況:" + ex.Message);
                    return;
                }

            }
        }

        private void comboBoxSize_SelectedValueChanged(object sender, EventArgs e)
        {
            DisplayQuantity();
            if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
            {
                try
                {
                    string photoPath = DisplayProductPhoto();
                    FileStream fs = File.OpenRead(photoPath);
                    pictureBoxProductPhoto.Image = Image.FromStream(fs);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("異常狀況:" + ex.Message);
                    return;
                }
            }
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtStock.Text,out int Quantity))
            {
                MessageBox.Show("請輸入正確商品變更數量!");
                return;
            }
            string size = comboBoxSize.Text;
            string color = comboBoxColor.Text;
            if (string.IsNullOrEmpty(size) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("請選擇正確的尺寸、顏色!");
                return;
            }

            var db = new AppDbContext();
            var sizeId = db.ProductSizes.Where(s=>s.SizeName == size).Select(s=>s.SizeId).FirstOrDefault();
            var colorId = db.ProductColors.Where(s=>s.ColorName == color).Select(s=>s.ColorId).FirstOrDefault();

            var Stock = db.ProductStockDetails.Where(psd=>psd.ProductId == _id
            &&psd.ColorId==colorId
            &&psd.SizeId==sizeId).FirstOrDefault();
            if (Stock != null)
            {
                Stock.Quantity = Quantity;
                db.SaveChanges();
                MessageBox.Show("庫存數量修改成功!");
                DisplayQuantity();
                if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
                {
                    try
                    {
                        string photoPath = DisplayProductPhoto();
                        FileStream fs = File.OpenRead(photoPath);
                        pictureBoxProductPhoto.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("異常狀況:" + ex.Message);
                        return;
                    }
                }


            }
            else
            {
                MessageBox.Show("新增失敗!請確認商品顏色及尺寸設定");
                return;
            }
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
            if (string.IsNullOrEmpty(comboBoxColor.Text) && string.IsNullOrEmpty(comboBoxSize.Text))
            {
                MessageBox.Show("請先選擇好需要新增照片的商品尺寸，顏色");
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
                && psd.SizeId == sizeId).FirstOrDefault();

            if (stockInDb == null)
            {
                throw new Exception("查無此庫存設定");

            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFolder = AppDomain.CurrentDomain.BaseDirectory;//存入至DEbug資料夾的路徑

                    string fileName = Path.GetFileName(openFileDialog.FileName);


                    string fileExtension = Path.GetExtension(openFileDialog.FileName);


                    string productName = txtProductName.Text;

                    string newFileName = "ProductId_" + productId + "_" + productName + "_" + comboBoxColor.Text + fileExtension; //改成新檔名



                    string newDestinationPath = Path.Combine(destinationFolder + "商品照片\\", newFileName);

                    try
                    {
                        if (File.Exists(newDestinationPath))
                        {
                            DialogResult result = MessageBox.Show("文件已存在，是否覆蓋？", "覆蓋確認", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                // 刪除現存文件
                                File.Delete(newDestinationPath);
                            }
                            else
                            {
                                MessageBox.Show("上傳已取消。");
                                return;
                            }
                        }

                        File.Copy(openFileDialog.FileName, newDestinationPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("上傳照片失敗" + ex.Message);
                    }



                    var productPhotos = new ProductPhoto
                    {
                        ProductPhotoName = productName + "_" + comboBoxColor.Text,
                        ProductPhotoPath = "商品照片\\" + newFileName
                    };
                    db.ProductPhotos.Add(productPhotos);
                    //member.PhotoPath = "商品照片\\" + newFileName;
                    db.SaveChanges();

                    var query = db.ProductPhotos.Where(pp => pp.ProductPhotoName == productName + "_" + comboBoxColor.Text
                    && pp.ProductPhotoPath == "商品照片\\" + newFileName).FirstOrDefault();
                    if (query != null)
                    {
                        int productPhotoId = query.ProductPhotoId;

                        var qureyPsd = db.ProductStockDetails
                                        .Where(psd => psd.ProductId == productId
                                                    && psd.ColorId == colorId
                                                    && psd.SizeId == sizeId).FirstOrDefault();

                        qureyPsd.ProductPhotoId = productPhotoId;
                        db.SaveChanges();
                        DisplayQuantity();
                        if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
                        {
                            try
                            {
                                string photoPath = DisplayProductPhoto();
                                FileStream fs = File.OpenRead(photoPath);
                                pictureBoxProductPhoto.Image = Image.FromStream(fs);
                                fs.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("異常狀況:" + ex.Message);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
