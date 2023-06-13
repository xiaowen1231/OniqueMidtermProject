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
    public partial class FormEditSize : Form
    {
        private readonly int _sizeId;
        public FormEditSize(int sizeId)
        {
            InitializeComponent();
            _sizeId = sizeId;
        }

        private void FormEditSize_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            var db = new AppDbContext();

            var query = db.ProductSizes.AsNoTracking()
                .Where(s=>s.SizeId==_sizeId)
                .Select(s=>s.SizeName)
                .FirstOrDefault();

            labelOriginalName.Text = query;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

            var sizeInDb = (db.ProductSizes
                .Where(s => s.SizeName == newName)
                .Select(s=> new SizeDto
                {
                    SizeId = s.SizeId,
                    SizeName = s.SizeName,
                })).FirstOrDefault();

            if (sizeInDb != null && sizeInDb.SizeId != _sizeId)
            {
                MessageBox.Show("修改後名稱重複!無法更新!");
                return;
            }
            else
            {
                var productSize = db.ProductSizes.Where(s=> s.SizeId == _sizeId).FirstOrDefault();

                productSize.SizeName = newName;

                db.SaveChanges();

                MessageBox.Show("尺寸名稱更新成功!");

                var parent = this.Owner as IGrid;

                if(parent != null)
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
            var query = db.ProductSizes.Where(p=>p.SizeId == _sizeId).FirstOrDefault();

            try
            {
                db.ProductSizes.Remove(query);
               
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
                MessageBox.Show("刪除失敗!原因:"+ex.Message);
            }
        }
    }
}
