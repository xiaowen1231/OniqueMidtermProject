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
    public partial class FormCreateEmployee : Form
    {
        private string _destinationFolderPath;

        public FormCreateEmployee()
        {
            InitializeComponent();
        }

        private void FormCreateEmployee_Load(object sender, EventArgs e)
        {
            var list = new AppDbContext().EmployeeLevels.Select(x => x.EmployeeLevelName).ToArray();
            comboBoxPosition.Items.AddRange(list);

            List<string> city = new EmployeeRepository().GetAllCityNames();
            foreach (var Citys in city)
            {
                comboboxCity.Items.Add(Citys);

            }

            dateTimePickerRegister.Value = DateTime.Now;
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            if (phone.Length != 10)
            {
                MessageBox.Show("電話長度須為10碼電話號碼!");
                return;
            }
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string position = comboBoxPosition.Text;
            string gender = (radioButtonMale.Checked ? "男" : "女");
            //int Citys = new EmployeeRepository().GetCityId(comboboxCity.Text);
            //int Areas = new EmployeeRepository().GetAreaId(comboboxArea.Text);
            DateTime dateofbirth = DateTimePickerBirth.Value;
            DateTime registerdate = dateTimePickerRegister.Value;
            //string photopath = _destinationFolderPath;

            var db = new AppDbContext();
            var employee = new EmployeeDto()
            {
                EmployeeName = name,
                Password = password,
                Phone = phone,
                Email = email,
                Address = address,
                Position = position,
                Gender = gender,
                Citys = comboboxCity.Text,
                Areas = comboboxArea.Text,
                DateOfBirth = dateofbirth,
                RegisterDate = registerdate,
                //PhotoPath = photopath,

            };

            try
            {
                var service = new EmployeeService();
                service.CreateCheck(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
                return;
            }

            // 關閉表單
            IGrid parent = this.Owner as IGrid; // 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
            if (parent == null) // 表示轉型失敗
            {
                MessageBox.Show("開啟我的表單, 它忘記實作 IGrid,所以無法通知它");
            }
            else
            {
                parent.Display(); // 呼叫它的 Display() 重新顯示資料
            }

            this.Close();
        }

        public void btnEditPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // 設置對話框的標題和允許的文件類型
                openFileDialog.Title = "選擇圖片文件";
                openFileDialog.Filter = "圖片文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                // 檢查使用者是否選擇了文件並點擊了「確定」按鈕
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 獲取所選文件的路徑
                    string imagePath = openFileDialog.FileName;

                    // 將圖片設定為 PictureBox 的圖像
                    pictureBox1.Image = Image.FromFile(imagePath);


                }

                string selectedFilePath = openFileDialog.FileName;
                //要存放的路徑
                _destinationFolderPath = "C:\\Users\\User\\Desktop\\專題\\slnBackgroundManagementSystem\\prjBackgroundManagementSystem\\bin\\Debug\\ProjectPicture";

                // 取得選取檔案的檔名
                string fileName = Path.GetFileName(selectedFilePath);

                // 組合目標資料夾路徑與檔名
                string destinationFilePath = Path.Combine(_destinationFolderPath, fileName);

                // 將檔案複製到目標資料夾
                File.Copy(selectedFilePath, destinationFilePath);
            }


        }

        private void comboboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxArea.Text = "請選擇";
            comboboxArea.Items.Clear();
            List<string> area = new EmployeeRepository().GetAreaNameOfCitys(comboboxCity.Text);
            foreach (var Area in area)
            {
                comboboxArea.Items.Add(Area);

            }
        }

        private void btnCancerAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimePickerBirth.Value > DateTime.Today)
            {
                MessageBox.Show("生日不可大於現在日期!");
                DateTimePickerBirth.Value = DateTime.Today;
            }
        }
    }
}
