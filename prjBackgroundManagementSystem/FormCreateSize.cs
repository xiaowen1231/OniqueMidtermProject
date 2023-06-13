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
    public partial class FormCreateSize : Form,IGrid
    {
        List<SizeDto> data = new List<SizeDto>();

        public FormCreateSize(int id)
        {
            InitializeComponent();
        }

        private void FormCreateSize_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAddSize_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSize.Text == string.Empty)
                {
                    MessageBox.Show("請輸入想新增的尺寸!");
                    return;
                }

                var db = new AppDbContext();

                var Productsize = db.ProductSizes
                    .Where(ps => ps.SizeName == txtSize.Text)
                    .Select(ps => ps.SizeName)
                    .FirstOrDefault();


                if (Productsize != null)
                {
                    MessageBox.Show("新增尺寸失敗，可能已有相同的尺寸，請確認後再試一次!");
                    return;
                }

                var dto = new SizeDto();

                string SizeName = txtSize.Text;
                var productSize = new ProductSize()
                {
                    SizeName = SizeName,
                };
                db.ProductSizes.Add(productSize);
                db.SaveChanges();
                MessageBox.Show("新增尺寸成功!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("新增尺寸失敗，可能已有相同的尺寸，請確認後再試一次!");
            }
        }

        public void Display()
        {
            string SizeName = string.Empty;
            data = new ProductRepository().CreateSize(SizeName);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int sizeId = data[e.RowIndex].SizeId;

            var frm = new FormEditSize(sizeId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
