using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.Repositoties;
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
    public partial class FormMember : Form, IGrid
    {

        private List<MemberDto> data;
        public FormMember()
        {
            InitializeComponent();
            this.Load += FormMember_Load;
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            this.AcceptButton = buttonSearch;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int MemberId = this.data[e.RowIndex].MemberId;
            var Frm = new FormEditMember(MemberId);
            Frm.Owner = this;
            Frm.ShowDialog();
        }

        public void Display()
        {

            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            data = new MemberRepository().Search(name, phone);

            dataGridView1.DataSource = data;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonAddNewMember_Click(object sender, EventArgs e)
        {
            var frm = new FormCreateMember();
            frm.Owner = this;
            frm.ShowDialog();

            //new FormEditMember
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
