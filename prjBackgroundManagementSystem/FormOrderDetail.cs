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
    public partial class FormOrderDetail : Form
    {

        List<OrderDetailDto> OrderProductsDetail = new List<OrderDetailDto>();

        private readonly int _orderId;

        public FormOrderDetail(int orderId)
        {
            InitializeComponent();
            this._orderId = orderId;
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            var repo = new OrderRepository();
            OrderDto dto = repo.Search(_orderId, null).FirstOrDefault();

            if (dto == null) 
            {
                MessageBox.Show("找不到訂單紀錄!");
                return;
            }

            textBoxId.Text = dto.Id.ToString();
            textBoxName.Text = dto.MemberName;
            textBoxOrderDate.Text = dto.OrderDate.ToShortDateString();

            textBoxShippingDate.Text = dto.ShippingDate.HasValue ?
                dto.ShippingDate.Value.ToShortDateString() : "訂單尚未出貨";

            textBoxCompletionDate.Text = dto.CompletionDate.HasValue ?
                dto.CompletionDate.Value.ToShortDateString() : "訂單尚未完成";

            labelStatus.Text = dto.OrderStatus;
            label1ShippingMethod.Text = dto.ShippingMethod;
            labelPayment.Text = dto.PaymentMethod;
            labelDiscount.Text = dto.Discount;
            labelAddress.Text = dto.Address;

            List<string> statusItems = repo.GetAllItems<OrderStatu>(o=>o.StatusName);
            foreach (var statusItem in statusItems)
            {
                comboBoxStatus.Items.Add(statusItem);
            }

            OrderProductsDetail = new OrderRepository().GetOrderProductList(_orderId);
            dataGridView1.DataSource= OrderProductsDetail;
            decimal ProductsPrice = OrderProductsDetail.Sum(x => x.Price*x.OrderQuantity);
            labelPrice.Text = ProductsPrice.ToString("0");

            decimal totalPrice = new DiscountRepository().CalculateDiscount(labelDiscount.Text, ProductsPrice);

            labelTotal.Text = totalPrice.ToString("0");
            if (labelDiscount.Text == "折抵運費")
            {
                labelFreight.Text = "0";
            }
            else
            {
                labelFreight.Text = "60";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            int orderDetailId = this.OrderProductsDetail[e.RowIndex].OrderDetailId;

            var frm = new FormEditOrderProduct(orderDetailId);
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
