using Onique.EStore.SqlDataLayer;
using Onique.EStore.SqlDataLayer.EFModels;
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
    public partial class FormCreateCategory : Form
    {
        public FormCreateCategory()
        {
            InitializeComponent();
        }

        private void btnComfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCategoryName.Text;
                bool isInt = int.TryParse(txtDisplayOrder.Text, out int DisplatOrder);

                var db = new AppDbContext();
                var category = new Category()
                {
                    CategoryName = name,
                    DisplayOrder = DisplatOrder
                };
                db.Categories.Add(category);
                db.SaveChanges();
                MessageBox.Show("新增成功");

                var parent = this.Owner as IGrid;
                if(parent != null)
                {
                    parent.Display();
                }
                else
                {
                    MessageBox.Show("請重新刷新表單確認!");
                }
            }
            catch
            {
                MessageBox.Show("新增失敗!");
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
