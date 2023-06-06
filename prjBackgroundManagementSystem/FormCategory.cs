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
    public partial class FormCategory : Form,IGrid
    {
        List<CategoryDto> categories;
        public FormCategory()
        {
            InitializeComponent();
        }

        public void Display()
        {
            cboxCategoryName.Items.Clear();
            cboxCategoryName.Items.AddRange((new AppDbContext().Categories.Select(c => c.CategoryName)).ToArray());
            int? categoryId = null;
            if (int.TryParse(this.txtCategoryId.Text, out int number))
            {
                categoryId = number;
            }

            string name = cboxCategoryName.Text;

            var db = new AppDbContext();
            var query = db.Categories.Select(x => new CategoryDto
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                DisplayOrder = x.DisplayOrder,
            }
            );
          

            if (categoryId.HasValue)
            {
                query = query.Where(c => c.CategoryId == categoryId.Value);
            }
            if (!string.IsNullOrEmpty(name) )
            {
                query = query.Where(c => c.CategoryName.Contains(name));
            }
            categories = query.ToList();


            this.dataGridView1.DataSource = categories;

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Display();           
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<CategoryDto>();
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            var createCategory = new FormCreateCategory();
            createCategory.Owner = this;
            createCategory.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int categoryId = categories[e.RowIndex].CategoryId;
            var updateOrDelete = new FormEditCategory(categoryId);
            updateOrDelete.Owner = this;
            updateOrDelete.ShowDialog();
        }
    }
}
