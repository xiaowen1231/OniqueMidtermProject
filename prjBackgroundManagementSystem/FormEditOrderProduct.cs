﻿using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
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
    public partial class FormEditOrderProduct : Form
    {
        private readonly int _orderDetailId;
        public FormEditOrderProduct(int orderDetailId)
        {
            this._orderDetailId = orderDetailId;
            InitializeComponent();
        }

        private void FormEditOrderProduct_Load(object sender, EventArgs e)
        {
            List<string> sizeData;
            OrderRepository repo = new OrderRepository();
            var dto = repo.GetOrderProductDetail(_orderDetailId);
            textBoxOrderId.Text = dto.OrderId.ToString();
            textBoxProductName.Text = dto.ProductName;
            textBoxSize.Text = dto.SizeName;
            textBoxPrice.Text = dto.Price.ToString("0");
            textBoxStockQuantity.Text = dto.StockQuantity.ToString();
            textBoxUpdateOrderQuantity.Text = dto.OrderQuantity.ToString();
            textBoxDescription.Text = dto.ProductDescription;
            textBoxColor.Text = dto.ColorName;
            
            sizeData = (repo.GetProductSize(textBoxProductName.Text));

            comboBoxUpdateSize.Items.AddRange(sizeData.ToArray());

            string loadImage = dto.PhotoPath;

            pictureBoxProductPhoto.Image =
                Image.FromFile(Path.Combine(loadImage));
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
