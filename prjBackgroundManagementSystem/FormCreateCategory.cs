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

        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
