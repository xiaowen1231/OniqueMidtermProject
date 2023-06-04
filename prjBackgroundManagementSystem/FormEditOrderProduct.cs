using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.Services;
using prjBackgroundManagementSystem.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormEditOrderProduct : Form
    {
        private readonly int _orderDetailId;

        private int _stockQuantity;

        public FormEditOrderProduct(int orderDetailId)
        {
            this._orderDetailId = orderDetailId;

            InitializeComponent();
        }

        private void FormEditOrderProduct_Load(object sender, EventArgs e)
        {
            OrderRepository repo = new OrderRepository();

            var dto = repo.GetOrderProductDetail(_orderDetailId);

            textBoxOrderId.Text = dto.OrderId.ToString();
            textBoxProductId.Text = dto.ProductId.ToString();
            textBoxProductName.Text = dto.ProductName;
            textBoxSize.Text = dto.SizeName;
            textBoxPrice.Text = dto.Price.ToString("0");
            textBoxOrderQuantity.Text = dto.OrderQuantity.ToString();
            textBoxStockQuantity.Text = dto.StockQuantity.ToString();
            textBoxDescription.Text = dto.ProductDescription;
            textBoxColor.Text = dto.ColorName;

            comboBoxUpdateColor.Items.AddRange(repo.GetProductColor(textBoxProductName.Text).ToArray());
            comboBoxUpdateSize.Items.AddRange(repo.GetProductSize(textBoxProductName.Text).ToArray());


            string loadImage = dto.PhotoPath;

            FileStream fs = File.OpenRead(loadImage);
            pictureBoxProductPhoto.Image = Image.FromStream(fs);
            fs.Close();
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelHint.Visible = false;
            if (!int.TryParse(textBoxProductId.Text, out int productId))
            {
                labelHint.Visible = true;
                labelHint.Text = "商品編號異常!";
                return;
            }
            if (!int.TryParse(textBoxUpdateOrderQuantity.Text,out int orderQuantity)) 
            {
                labelHint.Visible = true;
                labelHint.Text = "請輸入正確數字!";
                return;
            }
            if (orderQuantity > _stockQuantity)
            {
                labelHint.Visible = true;
                labelHint.Text = "商品庫存不足";
                return;
            }

            string size = comboBoxUpdateSize.Text;
            string color = comboBoxUpdateColor.Text;

            try
            {
                var service = new OrderService();
                service.UpdateOrderProduct(_orderDetailId, productId, orderQuantity, size, color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失敗!原因:" + ex.Message);
                return;
            }

            var parent = this.Owner as IGrid;

            if (parent == null)
            {
                MessageBox.Show("新增完成，請更新表單確認");
            }

            parent.Display();

            this.Close();
        }
        public void DisplayStockQuantity()
        {
            labelHint.Visible = false;

            if (!int.TryParse(textBoxProductId.Text, out int productId))
            {
                MessageBox.Show("商品編號異常");
            }

            if (!string.IsNullOrEmpty(comboBoxUpdateColor.Text) 
                && !string.IsNullOrEmpty(comboBoxUpdateSize.Text))
            {
                var repo = new OrderRepository();

                var dto = repo.GetProductStock(productId, comboBoxUpdateSize.Text, comboBoxUpdateColor.Text);

                if (dto != null)
                {

                    labelQuantity.Text = $"庫存數量" + dto.StockQuantity;
                    this._stockQuantity = dto.StockQuantity;

                    FileStream fs = File.OpenRead(dto.PhotoPath);
                    pictureBoxProductPhoto.Image = Image.FromStream(fs);
                    fs.Close();

                    buttonUpdate.Enabled = true;
                }
                else
                {
                    buttonUpdate.Enabled = false;
                }
            }
        }

        private void comboBoxUpdateColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStockQuantity();
        }

        private void comboBoxUpdateSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStockQuantity();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("確定刪除此項商品?", "刪除商品", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    new OrderRepository().DeleteOrderDetail(_orderDetailId);
                    var parent = this.Owner as IGrid;
                    if(parent != null)
                    {
                        parent.Display();
                        this.Close();
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("刪除失敗! 原因: " + ex.Message);
            }
            
        }
    }
}
