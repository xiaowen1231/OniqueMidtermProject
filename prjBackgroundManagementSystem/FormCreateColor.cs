using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
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
    public partial class FormCreateColor : Form
    {
        List<ColorDto> data = new List<ColorDto>();
        public FormCreateColor(int id)
        {
            InitializeComponent();
            this.Load += FormCreateColor_Load;
        }

        private void FormCreateColor_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            string ColorName = string.Empty;
            data = new ProductRepository().CreateColor(ColorName);
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
    }
}
