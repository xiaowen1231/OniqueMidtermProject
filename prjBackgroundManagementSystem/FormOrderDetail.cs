using Onique.EStore.SqlDataLayer.Dto;
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
    public partial class FormOrderDetail : Form
    {
        private readonly int _orderId;
        public FormOrderDetail(int orderId)
        {
            InitializeComponent();
            this._orderId = orderId;
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            OrderDto dto = new OrderRepository().Search(_orderId, null).FirstOrDefault();
            textBoxId.Text = dto.Id.ToString();
            textBoxName.Text = dto.MemberName;
            dateTimePickerOrder.Value = dto.OrderDate;
            dateTimePickerSendOut.Value = dto.ShippingDate.HasValue ?
                (DateTime)dto.ShippingDate : dateTimePickerSendOut.MinDate;
        }
    }
}
