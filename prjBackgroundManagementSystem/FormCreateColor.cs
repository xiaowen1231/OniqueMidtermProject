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
    public partial class FormCreateColor : Form ,IGrid
    {
        List<ColorDto> data = new List<ColorDto>();
        public FormCreateColor(int id)
        {
            InitializeComponent();
        }

        private void FormCreateColor_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            data = new ProductRepository().CreateColor();
            dataGridView1.DataSource = data;
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtColor.Text == string.Empty)
                {
                    MessageBox.Show("請輸入想要新增的顏色!");
                    return;
                }
                var db = new AppDbContext();
                var productcolor = db.ProductColors.Where(pc => pc.ColorName == txtColor.Text).Select(pc => pc.ColorName).FirstOrDefault();
                if (productcolor == txtColor.Text)
                {
                    MessageBox.Show("新增顏色失敗，可能已有相同的顏色，請確認後再試一次!");
                    return;
                }
                string ColorName = txtColor.Text;
                var productColor = new ProductColor()
                {
                    ColorName = ColorName,
                };
                db.ProductColors.Add(productColor);
                db.SaveChanges();
                MessageBox.Show("新增顏色成功!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("新增顏色失敗，可能已有相同的顏色，請確認後再試一次!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }

            int id = this.data[e.RowIndex].ColorId;

            var frm = new FormEditColor(id);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
