using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
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
    public partial class FormEditEmployee : Form
    {
        private readonly int _EmployeeId;
        public FormEditEmployee(int EmployeeId)
        {
            this._EmployeeId = EmployeeId;
            InitializeComponent();
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            this.LoadEmployee();
        }

        private void LoadEmployee()
        {
            comboBoxPosition.Items.Clear();
            var repo = new EmployeeRepository();
            EmployeeDto dto = repo.Get(_EmployeeId);
            List<string> city = new EmployeeRepository().GetAllCityNames();
            comboBoxPosition.Items.AddRange(repo.GetPositionItems().ToArray());
            txtName.Text = dto.EmployeeName;
            txtPassword.Text = dto.Password;
            txtPhone.Text = dto.Phone;
            txtEmail.Text = dto.Email;
            comboboxCity.Text = dto.Citys;
            comboBoxArea.Text = dto.Areas;
            txtAddress.Text = dto.Address;
            comboBoxPosition.Text = dto.Position;
            dateTimePickerBirth.Value = dto.DateOfBirth!=null? dto.DateOfBirth.Value :dateTimePickerBirth.MinDate;
            dateTimePickerRegister.Value = dto.RegisterDate.Date;

            foreach (var Citys in city)
            {
                comboboxCity.Items.Add(Citys);

            }

            if (dto.Gender.Equals(false))
            {
                radioButtonMale.Checked = true;
            }
            else { radioButtonFemale.Checked = true; }

            LoadEmployeePhoto(dto.PhotoPath);

        }

        private void ShowAreaNames()
        {
            comboBoxArea.Items.Clear();

            List<string> areadata = new EmployeeRepository().GetAreaNameOfCitys(comboboxCity.Text);
            foreach (var area in areadata)
            {
                comboBoxArea.Items.Add(area);
            }
        }

        private void comboboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArea.Text = "請選擇";
            ShowAreaNames();
        }

        private void btnComfirmAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("信箱尚未填寫 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("姓名尚未填寫 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("密碼尚未填寫 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text) || txtPhone.Text.Length != 10)
            {
                MessageBox.Show("電話填寫錯誤 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxPosition.Text))
            {
                MessageBox.Show("身分尚未選擇 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(comboboxCity.Text))
            {
                MessageBox.Show("縣市尚未選擇 ! 無法編輯資料!");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxArea.Text) || comboBoxArea.Text == "請選擇")
            {
                MessageBox.Show("地區尚未選擇 ! 無法編輯資料!");
                return;
            }

            var db = new AppDbContext();
            int positionId = db.EmployeeLevels
                .Where(s => s.EmployeeLevelName == comboBoxPosition.Text)
                .Select(s => s.EmployeeLevelId)
                .FirstOrDefault();

            var repo = new EmployeeRepository();
            var dtoInDb = repo.GetByPhone(new EmployeeDto { Phone = txtPhone.Text });
            var dto = repo.GetEmployeeByEmail(new EmployeeDto { Email=txtEmail.Text});
            if (dto != null)
            {
                if (!string.IsNullOrEmpty(dto.Email) && dto.EmployeeId != _EmployeeId)
                {
                    MessageBox.Show("已有此信箱");
                    return;
                }
            }
            
            if (dtoInDb != null&&dtoInDb.EmployeeId!=_EmployeeId)
            {
                MessageBox.Show("抱歉, 此電話已存在,無法新增");
                return;
            }

            var nowEmployee = db.Employees.Find(_EmployeeId);

            nowEmployee.EmployeeName = txtName.Text;
            nowEmployee.Password = txtPassword.Text;
            nowEmployee.Phone = txtPhone.Text;
            nowEmployee.Email = txtEmail.Text;
            nowEmployee.Position = positionId;
            nowEmployee.Address = txtAddress.Text;
            nowEmployee.Citys = new EmployeeRepository().GetCityId(comboboxCity.Text);
            nowEmployee.Areas = new EmployeeRepository().GetAreaId(comboBoxArea.Text);
            nowEmployee.Gender = radioButtonMale.Checked ? false : true;
            nowEmployee.DateOfBirth = dateTimePickerBirth.Value;
            nowEmployee.RegisterDate = dateTimePickerRegister.Value;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("新增失敗!請檢查原因!!");
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("確認刪除?", "刪除會員資料", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var db = new AppDbContext();
                var category = db.Employees.Find(_EmployeeId);

                if (category == null)
                {
                    MessageBox.Show("record not found");
                    return;
                }
                db.Employees.Remove(category);
                db.SaveChanges();
                IGrid parent = this.Owner as IGrid; // 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
                if (parent == null) // 表示轉型失敗
                {
                    MessageBox.Show("開啟我的表單, 它忘記實作 IGrid,所以無法通知它");
                }
                else
                {
                    parent.Display(); // 呼叫它的 Display() 重新顯示資料
                }
            }

            this.Close();
        }

        private void btnCancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEmployeePhoto(string photopath)
        {

            if (photopath == null)
            {
                photopath = "default.jpg";
            }
            try
            {
                FileStream fileStream = File.OpenRead(photopath);
                pictureBox1.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("照片讀取失敗!");
            }
        }

        private void RenewGridVierData()
        {
            IGrid parent = this.Owner as IGrid; // 將開啟我的那個視窗, 轉型成 IGrid, 如果轉型失敗,不會丟出例外, 而是傳回null
            if (parent == null) // 表示轉型失敗
            {
                MessageBox.Show("開啟我的表單, 它忘記實作 IGrid,所以無法通知它");
            }
            else
            {
                parent.Display(); // 呼叫它的 Display() 重新顯示資料
            }
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFolder = AppDomain.CurrentDomain.BaseDirectory;//存入至DEbug資料夾的路徑

                    string fileName = Path.GetFileName(openFileDialog.FileName);


                    string fileExtension = Path.GetExtension(openFileDialog.FileName);


                    int employeeId = _EmployeeId;
                    string memberName = new EmployeeRepository().Get(employeeId).EmployeeName;

                    string newFileName = "EmployeeId_" + employeeId + "_" + memberName + fileExtension; //改成新檔名



                    string newDestinationPath = Path.Combine(destinationFolder + "ProjectPicture\\", newFileName);

                    try
                    {
                        if (File.Exists(newDestinationPath))
                        {
                            DialogResult result = MessageBox.Show("文件已存在，是否覆蓋？", "覆蓋確認", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                // 删除现有文件
                                File.Delete(newDestinationPath);
                            }
                            else
                            {
                                MessageBox.Show("上傳已取消。");
                                return;
                            }
                        }

                        File.Copy(openFileDialog.FileName, newDestinationPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("上傳照片失敗" + ex.Message);
                    }



                    var db = new AppDbContext();
                    var employee = db.Employees.Find(_EmployeeId);
                    employee.PhotoPath = "ProjectPicture\\" + newFileName;
                    db.SaveChanges();
                    RenewGridVierData();
                    LoadEmployeePhoto(employee.PhotoPath);

                }
            }

        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBirth.Value > DateTime.Today)
            {
                MessageBox.Show("生日不可大於現在日期!");
                dateTimePickerBirth.Value = DateTime.Today;
            }
        }
    }
}
