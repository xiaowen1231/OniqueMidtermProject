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
    public partial class FormSelectMember : Form
    {
        List<SelectMemberDto> data;
        public FormSelectMember()
        {
            InitializeComponent();
        }

        private void FormSelectMember_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            data = new OrderRepository().GetMemberOfSelect(textBoxName.Text);
            dataGridView1.DataSource = data;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }

            string name = this.data[e.RowIndex].Name;
            string photoPath = this.data[e.RowIndex].Photo;

            var parent = this.Owner as IUpdateInfo;

            if (parent != null)
            {
                parent.changeInfo(name, photoPath);
            }
            this.Close();
        }
    }
}
