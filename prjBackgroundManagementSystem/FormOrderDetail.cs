using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.Services;
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
    public partial class FormOrderDetail : Form, IGrid
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
            Display();
        }

        public void Display()
        {
            
            labelHint.Visible = false;
            labelStatus.ForeColor = Color.DarkMagenta;
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Text = string.Empty;
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

            List<string> statusItems = repo.GetAllItems<OrderStatu>(o => o.StatusName);
            comboBoxStatus.Items.AddRange(statusItems.ToArray());

            OrderProductsDetail = new OrderRepository().GetOrderProductList(_orderId);
            dataGridView1.DataSource = OrderProductsDetail;
            decimal ProductsPrice = OrderProductsDetail.Sum(x => x.Price * x.OrderQuantity);
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
            if (labelStatus.Text != "待出貨")
            {
                labelHint.Text = "訂單狀態不可編輯商品!";
                labelStatus.ForeColor = Color.LightSeaGreen;
                labelHint.Visible = true;
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }

            int orderDetailId = this.OrderProductsDetail[e.RowIndex].OrderDetailId;

            var frm = new FormEditOrderProduct(orderDetailId);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text != "待出貨")
            {
                labelHint.Text = "訂單狀態不可新增商品!";
                labelStatus.ForeColor = Color.LightSeaGreen;
                labelHint.Visible = true;
                return;
            }
            if (!int.TryParse(textBoxId.Text, out int orderId))
            {
                MessageBox.Show("無法取得訂單編號");
                return;
            }

            var frm = new FormAddOrderProduct(orderId);
            frm.Owner = this;
            frm.ShowDialog();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (OrderProductsDetail.Count == 0)
            {
                MessageBox.Show("訂單尚未選擇任何商品!");
                return;
            }
            try
            {
                var service = new OrderService();
                

                foreach (var productDetail in this.OrderProductsDetail)
                {
                    service.UpdateStockQuantity(productDetail.ProductName,
                        productDetail.SizeName,
                        productDetail.ColorName,
                        productDetail.OrderQuantity,
                        comboBoxStatus.Text,
                        labelStatus.Text);

                }

                service.UpdateOrderStatus(_orderId, comboBoxStatus.Text
                    , labelStatus.Text, labelPayment.Text);

                MessageBox.Show("訂單狀態修改成功");

                Display();

                var parent = this.Owner as IGrid;

                if (parent != null)
                {
                    parent.Display();
                }
                else
                {
                    MessageBox.Show("刪除成功! 請重新開啟表單確認資訊!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("無法更新訂單狀態!原因:" + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int orderItems = OrderProductsDetail.Count;
            if (!int.TryParse(textBoxId.Text, out int orderId))
            {
                MessageBox.Show("無法正確取的訂單編號!");
                return;
            }
            else if (labelStatus.Text != "已取消" && labelStatus.Text != "待出貨")
            {
                MessageBox.Show("訂單狀態為無法刪除的訂單!");
                return;
            }
            try
            {
                var result = MessageBox.Show("確定刪除此訂單嗎?", "刪除訊息", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    new OrderService().DeleteOrder(orderItems, orderId);
                }
                else
                {
                    return;
                }
                var parent = this.Owner as IGrid;

                if (parent != null)
                {
                    parent.Display();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("刪除成功! 請重新開啟表單確認資訊!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("刪除訂單失敗! 原因: " + ex.Message);
            }
        }
    }
}
