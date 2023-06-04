using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.Services;
using prjBackgroundManagementSystem.Delegate;
using prjBackgroundManagementSystem.interfaces;
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
    public partial class FormAddOrderProduct : Form,IGrid
    {
        
        private readonly int _orderId;
        private int _stockQuantity;
        private int _id;
        public int id 
        { 
            get { return _id; } 
            set { _id = value;}
        }  
        public FormAddOrderProduct(int orderId)
        {
            InitializeComponent();
            this._orderId = orderId;
        }

        public void Display()
        {
            comboBoxSize.Items.Clear();
            comboBoxColor.Items.Clear();
            if (_id == 0)
            {
                return;
            }
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
            var parent = this.Owner as IGrid;
            if (parent != null)
            {
                parent.Display();
            }
            this.Close();

        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            comboBoxColor.Items.Clear();
            comboBoxSize.Items.Clear();
            textBoxProductName.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            labelQuantity.Text = "庫存數量:";
            _stockQuantity = 0;
            labelHint.Visible= false;
            pictureBoxProductPhoto.Image = null;
            var frm = new FormSelectProduct(_orderId);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void FormAddOrderProduct_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
