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
    public partial class FormAddOrderProduct : Form
    {
        private readonly int _id;
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
            if (!string.IsNullOrEmpty(comboBoxColor.Text) && !string.IsNullOrEmpty(comboBoxSize.Text))
            {
                var repo = new OrderRepository();
                var dto = repo.GetProductStock(_id,comboBoxSize.Text,comboBoxColor.Text);
                if (dto != null)
                {
                    labelHint.Text = $"庫存數量" + dto.StockQuantity;
                    FileStream fs = File.OpenRead(dto.PhotoPath);
                    pictureBoxProductPhoto.Image = Image.FromStream(fs);
                    fs.Close();
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
            //if(string.IsNullOrEmpty(comboBoxColor.Text))
        }
    }
}
