using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.ViewModels;
using prjBackgroundManagementSystem.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormEditMember : Form
    {
        private readonly int _MemberId;
        public List<MemberDto> data;

        public FormEditMember(int MemberId)
        {
            this._MemberId = MemberId;//傳入的memberId，等同建構表單時的memberId
            InitializeComponent();
        }
        private (bool isValid, List<ValidationResult> errors) Validate(MemberCreateVM vm)
        {
            // 得知要驗證規則
            ValidationContext context = new ValidationContext(vm, null, null);

            // 用來存放錯誤的集合,因為可能有零到多個錯誤
            List<ValidationResult> errors = new List<ValidationResult>();

            // 驗證 model
            bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
            bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

            return (isValid, errors);
        }
        private void DisplayErrors(List<ValidationResult> errors)
        {
            // 大小寫不同仍視為相同的key
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Name", textBoxName},
                {"Password",textBoxPassword },
                {"Phone",textBoxPhone },
                {"Email", textBoxEmail},
                {"Address",textBoxAddress},
                {"Gender", radioButtonFemale},
                {"AreaName",comboBoxArea},
                {"MemberLevelName",comboBoxMemberLevel},
                {"DateOfBirth",dateTimePickerDateOfBirth }


            };

            this.errorProvider1.Clear();

            foreach (ValidationResult error in errors)
            {
                string propName = error.MemberNames.FirstOrDefault();
                if (map.TryGetValue(propName, out Control ctrl))
                {
                    this.errorProvider1.SetError(ctrl, error.ErrorMessage);
                }
            }
        }
        private void FormEditMember_Load(object sender, EventArgs e)
        {
            LoadMemberData();
            ShowAreaName();
            //LoadMemberPhoto();


        }
        //todo
        private void LoadMemberPhoto(string photopath)
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



        private void LoadMemberData()
        {
            comboBoxMemberLevel.Items.Clear();
            var levelData = new AppDbContext().MemberLevels.Select(m => m.MemberLevelName).ToList();
            comboBoxMemberLevel.Items.AddRange(levelData.ToArray());
            var repo = new MemberRepository();
            MemberDto dto = repo.Get(_MemberId);
            List<string> cityNames = new MemberRepository().GetAllCity();

            textBoxMemberId.Text = dto.MemberId.ToString();
            textBoxName.Text = dto.Name;
            textBoxPassword.Text = dto.Password;
            textBoxPhone.Text = dto.Phone;
            textBoxEmail.Text = dto.Email;
            comboBoxCity.Text = dto.CityName;
            comboBoxArea.Text = dto.AreaName;

            textBoxAddress.Text = dto.Address;
            if (string.IsNullOrEmpty(dto.Address))
            {
                textBoxAddress.Text = "會員未輸入住址";
            }

            comboBoxMemberLevel.Text = dto.MemberLevelName;
            dateTimePickerDateOfBirth.Value = dto.DateOfBirth.Date;
            dateTimePickerRegisterDate.Value = dto.RegisterDate.Date;

            if (dto.Gender == "男")
            {
                radioButtonMale.Checked = true;
            }
            else { radioButtonFemale.Checked = true; }

            foreach (var cityName in cityNames)
            {
                comboBoxCity.Items.Add(cityName);
            }


            LoadMemberPhoto(dto.PhotoPath);



        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {//todo
            DialogResult dr = MessageBox.Show("確認刪除?", "刪除會員資料", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var db = new AppDbContext();
                var memberdto = db.Members.Find(_MemberId);

                if (memberdto == null)
                {
                    MessageBox.Show("record not found");
                    return;
                }

                db.Members.Remove(memberdto);
                db.SaveChanges();
                RenewGridVierData();
                this.Close();
            }

        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxArea.Text == "請選擇")
            {
                MessageBox.Show("地區尚未選擇");
                return;
            }

            var db = new AppDbContext();
            var member = db.Members.Find(_MemberId);

            member.MemberId = _MemberId;
            member.Name = textBoxName.Text;
            member.Password = textBoxPassword.Text;
            member.Phone = textBoxPhone.Text;
            member.Email = textBoxEmail.Text;
            member.Address = textBoxAddress.Text;
            member.MemberLevel = new MemberRepository().GetMemberLevelId(comboBoxMemberLevel.Text);
            member.Citys = new MemberRepository().GetCityId(comboBoxCity.Text);
            member.Areas = new MemberRepository().GetAreaId(comboBoxArea.Text);
            member.Gender = radioButtonMale.Checked ? false : true;
            member.RegisterDate = dateTimePickerRegisterDate.Value;
            member.DateOfBirth = dateTimePickerDateOfBirth.Value;



            //vm
            var vm = new MemberCreateVM()
            {
                Name = textBoxName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                MemberLevelName = comboBoxMemberLevel.Text,
                CityName = comboBoxCity.Text,
                AreaName = comboBoxArea.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value,
                RegisterDate = dateTimePickerRegisterDate.Value
            };


            // 驗證vm是否通過欄位驗證規則
            (bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

            //如果有錯, 就顯示它
            if (validationResult.isValid == false)
            {
                this.errorProvider1.Clear();
                DisplayErrors(validationResult.errors);
                return;
            }


            //MemberDto memberDto = new MemberDto()
            //{
            //	MemberId=member.MemberId,	
            //	Name = member.Name,
            //	Password = member.Password,
            //	Phone = member.Phone,
            //	Email = member.Email,
            //	Address = member.Address,
            //	MemberLevelName=comboBoxMemberLevel.Text,
            //	CityName=comboBoxCity.Text,
            //	AreaName=comboBoxArea.Text,
            //	Gender=gender,
            //	RegisterDate=member.RegisterDate,
            //	DateOfBirth=member.DateOfBirth

            //};
            //try
            //{
            //	new MemberService().Update(memberDto);
            //}
            //catch (Exception ex)
            //{
            //	MessageBox.Show(ex.Message);
            //}

            db.SaveChanges();

            RenewGridVierData();
            this.Close();

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


        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArea.Text = "請選擇";
            ShowAreaName();
        }

        private void ShowAreaName()
        {
            comboBoxArea.Items.Clear();

            List<string> areaData = new MemberRepository().GetAreaOfCity(comboBoxCity.Text);
            foreach (var area in areaData)//依選定的cityname一筆筆填入資料
            {
                comboBoxArea.Items.Add(area);
            }
        }


        private void btnEditPhoto_Click(object sender, EventArgs e)//應該可以更精簡
        {


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFolder = AppDomain.CurrentDomain.BaseDirectory;//存入至DEbug資料夾的路徑

                    string fileName = Path.GetFileName(openFileDialog.FileName);


                    string fileExtension = Path.GetExtension(openFileDialog.FileName);


                    int memberId = _MemberId;
                    string memberName = new MemberRepository().Get(memberId).Name;

                    string newFileName = "MemberId_" + memberId + "_" + memberName + fileExtension; //改成新檔名



                    string newDestinationPath = Path.Combine(destinationFolder + "ProjectPicture\\", newFileName);

                    try
                    {
                        if (File.Exists(newDestinationPath))
                        {
                            DialogResult result = MessageBox.Show("文件已存在，是否覆蓋？", "覆蓋確認", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                // 刪除現存文件
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
                    var member = db.Members.Find(_MemberId);
                    member.PhotoPath = "ProjectPicture\\" + newFileName;
                    db.SaveChanges();
                    RenewGridVierData();
                    LoadMemberPhoto(member.PhotoPath);


                }
            }
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDateOfBirth.Value > DateTime.Today)
            {

                labelAlarm.Visible = true;
                buttonConfirmEdit.Enabled = false;
            }
            else
            {
                labelAlarm.Visible = false;
                buttonConfirmEdit.Enabled = true;
            }
        }

    }
}
