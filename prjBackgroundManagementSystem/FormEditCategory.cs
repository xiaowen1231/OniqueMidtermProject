using Onique.EStore.SqlDataLayer;
using Onique.EStore.SqlDataLayer.EFModels;
using prjBackgroundManagementSystem.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjBackgroundManagementSystem
{
    public partial class FormEditCategory : Form
    {
        private readonly int _categoryId;
        public FormEditCategory(int categoryId)
        {
            _categoryId = categoryId;
            InitializeComponent();
        }
        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            var repo = new CategoryRepository();
            CategoryDto dto = repo.Get(_categoryId);
            if (dto == null)
            {
                MessageBox.Show("找不到符合紀錄");
                return;
            }

            txtCategoryName.Text = dto.CategoryName.ToString();
            txtDisplayOrder.Text = dto.DisplayOrder.ToString();
        }

        private void btnComfirmUpdate_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);
            displayOrder = isInt ? displayOrder : 0;

            CategoryDto dto = new CategoryDto { CategoryId = this._categoryId, CategoryName = txtCategoryName.Text, DisplayOrder = displayOrder };


            try
            {
                var service = new CategoryService();
                int rows = service.Update(dto);
                if (rows > 0)
                {
                    MessageBox.Show("更新成功");
                }
                else
                {
                    MessageBox.Show("更新失敗，原因: 可能是沒有這筆紀錄，例如已經被別人刪除");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失敗， 原因: " + ex.Message);
            }


            IGrid parent = this.Owner as IGrid;
            if (parent == null)
            {
                MessageBox.Show("開啟我的表單，他忘記實作IGrid，所以無法通知他");
            }
            else
            {
                parent.Display();
            }
            this.Close();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var repo = new CategoryRepository();
            try
            {
                int rows = repo.Delete(_categoryId);

                if (rows > 0)
                {
                    MessageBox.Show("刪除成功");
                }
                else
                {
                    MessageBox.Show("刪除失敗");
                }

                IGrid parent = this.Owner as IGrid;
                if (parent == null)
                {
                    MessageBox.Show("開啟我的表單，他忘記實作IGrid，所以無法通知他");
                }
                else
                {
                    parent.Display();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除失敗，原因: " + ex.Message);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
