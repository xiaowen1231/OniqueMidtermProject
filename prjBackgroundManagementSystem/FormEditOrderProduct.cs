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
    public partial class FormEditOrderProduct : Form
    {
        private readonly int _orderId;
        public FormEditOrderProduct(int orderId)
        {
            this._orderId = orderId;
            InitializeComponent();
        }

        private void FormEditOrderProduct_Load(object sender, EventArgs e)
        {
            OrderDto dto = new OrderRepository().Search(_orderId, null).FirstOrDefault();
            if (dto != null)
            {
                
            }
        }
    }
}
