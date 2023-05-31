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
    public partial class FormCreateOrder : Form, IUpdateInfo
    {
        public FormCreateOrder()
        {
            InitializeComponent();
        }

        private void buttonSelectMember_Click(object sender, EventArgs e)
        {
            var frm = new FormSelectMember();
            frm.Owner = this;
            frm.ShowDialog();

        }
        public void changeInfo(string name, string photoPath)
        {
            textBoxName.Text = name;
            if (photoPath != null)
            {
                FileStream fs = File.OpenRead(photoPath);
                pictureBoxMemberPhoto.Image = Image.FromStream(fs);
                fs.Close();

            }
        }
    }
}
