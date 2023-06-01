using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.Services;
using prjBackgroundManagementSystem.Delegate;
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
    public partial class FormAddOrderProduct : Form
    {
        private readonly int _id;


        private int _orderId;
        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }


        private int _stockQuantity;
        public FormAddOrderProduct(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void FormAddOrderProduct_Load(object sender, EventArgs e)
        {
            var repo = new OrderRepository();
            textBoxProductName.Text = repo.GetProductName(_id);
            comboBoxSize.Items.AddRange(repo.GetProductSize(textBoxProductName.Text).ToArray());
            comboBoxColor.Items.AddRange(repo.GetProductColor(textBoxProductName.Text).ToArray());

        }

        public void DisplayStockQuantity()
        {
            labelHint.Visible = false;
            if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
            {
                var repo = new OrderRepository();
                var dto = repo.GetProductStock(_id, comboBoxSize.Text, comboBoxColor.Text);
                if (dto != null)
                {

                    labelQuantity.Text = $"庫存數量" + dto.StockQuantity;
                    this._stockQuantity = dto.StockQuantity;

                    FileStream fs = File.OpenRead(dto.PhotoPath);
                    pictureBoxProductPhoto.Image = Image.FromStream(fs);
                    fs.Close();

                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonAdd.Enabled = false;
                }
            }
        }
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStockQuantity();
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayStockQuantity();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelHint.Visible = false;
            if (!int.TryParse(textBoxQuantity.Text, out int orderQuantity))
            {
                labelHint.Visible = true;
                labelHint.Text = "請輸入正確數字!";
                return;
            };

            if (orderQuantity > _stockQuantity)
            {
                labelHint.Visible = true;
                labelHint.Text = "庫存量不足!請重新選擇數量!";
                return;
            }
            try
            {
                var service = new OrderService();
                service.CreateOrderDetail(_orderId, textBoxProductName.Text, orderQuantity
                    , comboBoxSize.Text, comboBoxColor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法新增商品於訂單中!原因:" + ex.Message);
            }
            
        }
    }
}
