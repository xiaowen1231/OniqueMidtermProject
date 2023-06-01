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
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show("載入照片異常");
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string method = comboBoxShippingMethod.Text;
            string payment = comboBoxPayment.Text;
            string discount = comboBoxDiscount.Text;
            string address = textBoxAddress.Text;
            try
            {
                var service = new OrderService();
                service.CreateOrder(name, method, address, payment, discount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗!原因:"+ex.Message);
            }

            var parent = this.Owner as IGrid;
            if(parent==null)
            {
                MessageBox.Show("請回到訂單管理頁面確認是否新增成功");
            }

            parent.Display();

            this.Close();
        }
    }
}
