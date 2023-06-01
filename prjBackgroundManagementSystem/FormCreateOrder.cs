using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormCreateOrder : Form
    {
        public FormCreateOrder()
        {
            InitializeComponent();
        }

        private void buttonSelectMember_Click(object sender, EventArgs e)
        {
            var frm = new FormSelectMember();
            frm.callChange = this.changeInfo;
            frm.Owner = this;
            frm.ShowDialog();

        }
        public void changeInfo(string name, string photoPath, string address)
        {
            comboBoxDiscount.Items.Clear();
            comboBoxPayment.Items.Clear();
            comboBoxShippingMethod.Items.Clear();

            textBoxName.Text = name;
            if (photoPath != null)
            {
                FileStream fs = File.OpenRead(photoPath);
                pictureBoxMemberPhoto.Image = Image.FromStream(fs);
                fs.Close();

            }
            else
            {
                FileStream fs = File.OpenRead("ProjectPicture\\default.jpg");
                pictureBoxMemberPhoto.Image = Image.FromStream(fs);
                fs.Close();
            }
            OrderRepository repo = new OrderRepository();
            List<string> shipping = repo.GetAllItems<ShippingMethod>(s => s.MethodName);
            comboBoxShippingMethod.Items.AddRange(shipping.ToArray());
            List<string> payment = repo.GetAllItems<PaymentMethod>(p => p.PaymentMethodName);
            comboBoxPayment.Items.AddRange(payment.ToArray());
            List<string> discount = repo.GetAllItems<Discount>(d => d.DiscountName);
            comboBoxDiscount.Items.AddRange(discount.ToArray());
            textBoxAddress.Text = address;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
        }

        private void buttonDeselect_Click(object sender, EventArgs e)
        {
            
            pictureBoxMemberPhoto.Image = null;

            textBoxName.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            
            comboBoxShippingMethod.Text = string.Empty;
            comboBoxShippingMethod.Items.Clear();

            comboBoxDiscount.Text = string.Empty;
            comboBoxDiscount.Items.Clear();

            comboBoxPayment.Text = string.Empty;
            comboBoxPayment.Items.Clear();

            textBoxAddress.Text = string.Empty;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var frm = new FormSelectProduct();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
