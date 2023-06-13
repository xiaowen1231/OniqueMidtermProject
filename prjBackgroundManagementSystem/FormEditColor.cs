using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
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
    public partial class FormEditColor : Form
    {
        private readonly int _colorId;
        public FormEditColor(int id)
        {
            InitializeComponent();
            _colorId = id;
        }

        private void FormEditColor_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void Display()
        {
            var db = new AppDbContext();

            var query = db.ProductColors.AsNoTracking()
                .Where(s => s.ColorId == _colorId)
                .Select(s => s.ColorName)
                .FirstOrDefault();

            labelOriginalName.Text = query;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string newName = textBoxUpdateName.Text;

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("未輸入修改名稱!");
                return;
            }

            var db = new AppDbContext();

            var sizeInDb = (db.ProductColors
                .Where(s => s.ColorName == newName)
                .Select(s => new ColorDto
                {
                    ColorId = s.ColorId,
                    ColorName = s.ColorName,
                })).FirstOrDefault();

            if (sizeInDb != null && sizeInDb.ColorId != _colorId)
            {
                MessageBox.Show("修改後名稱重複!無法更新!");
                return;
            }
            else
            {
                var productColor = db.ProductColors.Where(s => s.ColorId == _colorId).FirstOrDefault();

                productColor.ColorName = newName;

                db.SaveChanges();

                MessageBox.Show("顏色名稱更新成功!");

                var parent = this.Owner as IGrid;

                if (parent != null)
                {
                    parent.Display();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("請重新刷新頁面確認!");
                    return;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var query = db.ProductColors.Where(p => p.ColorId == _colorId).FirstOrDefault();

            try
            {
                db.ProductColors.Remove(query);
               
                db.SaveChanges();
                MessageBox.Show("刪除成功!");
                var parent = this.Owner as IGrid;

                if (parent != null)
                {
                    parent.Display();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("請重新刷新頁面確認!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗!原因:" + ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
