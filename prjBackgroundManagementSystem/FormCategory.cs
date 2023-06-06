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
    public partial class FormCategory : Form
    {
        
        public FormCategory()
        {
            InitializeComponent();
        }

        private void Display()
        {
            var db = new AppDbContext();
            var categories = from c in db.Categories.AsNoTracking()
                             join p in db.Products.AsNoTracking()
                             on c.CategoryId equals p.ProductCategoryId
                             select new
                             {
                                 CategoryId = c.CategoryId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName
                             };
        
            this.dataGridView1.DataSource = categories.ToList();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
