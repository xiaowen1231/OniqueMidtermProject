using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using Onique.EStore.SqlDataLayer.Repositoties;
using Onique.EStore.SqlDataLayer.Services;
using Onique.EStore.SqlDataLayer.ViewModels;
using prjBackgroundManagementSystem.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBackgroundManagementSystem
{
    public partial class FormCreateMember : Form
    {
        public FormCreateMember()
        {
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
        private void FormCreateMember_Load(object sender, EventArgs e)
        {
            comboBoxMemberLevel.Items.Clear();
            var levelData = new AppDbContext().MemberLevels.Select(m=>m.MemberLevelName).ToList();
            comboBoxMemberLevel.Items.AddRange(levelData.ToArray());
            //獲取combobox資料，用於選取
            List<string> cityNames = new MemberRepository().GetAllCity();
            foreach (string city in cityNames)
            {
                comboBoxCity.Items.Add(city);
            }

            dateTimePickerRegisterDate.Value = DateTime.Now;

        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArea.Text = "請選擇";
            comboBoxArea.Items.Clear();
            List<string> areaNames = new MemberRepository().GetAreaOfCity(comboBoxCity.Text);
            foreach (string areaName in areaNames)
            {
                comboBoxArea.Items.Add(areaName);
            }

        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            if (labelAlarm.Visible == false)
            {
                MessageBox.Show("請先進行信箱驗證!");
                return;
            }
            if (labelAlarm.Text != "信箱可使用!")
            {
                MessageBox.Show("信箱已被使用!無法註冊");
                return;
            }

            if (comboBoxArea.Text == "請選擇")
            {
                MessageBox.Show("請選擇地區");
                return;
            }
            if (dateTimePickerDateOfBirth.Value > DateTime.Today)
            {
                MessageBox.Show("日期選擇錯誤");
                return;
            }
            //收集欄位資料

            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            string gender = (radioButtonMale.Checked ? "男" : "女");
            int memberLevel = new MemberRepository().GetMemberLevelId(comboBoxMemberLevel.Text);
            int citys = new MemberRepository().GetCityId(comboBoxCity.Text);
            int areas = new MemberRepository().GetAreaId(comboBoxArea.Text);
            DateTime? dateOfBirth = dateTimePickerDateOfBirth.Value;
            DateTime registerDate = dateTimePickerRegisterDate.Value;



            var vm = new MemberCreateVM()
            {
                Name = name,
                Password = password,
                Phone = phone,
                Email = email,
                Address = address,
                Gender = (radioButtonMale.Checked ? false : true),
                MemberLevelName = comboBoxMemberLevel.Text,
                CityName = comboBoxCity.Text,
                AreaName = comboBoxArea.Text,
                DateOfBirth = dateOfBirth,
                RegisterDate = registerDate
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


            MemberDto member = new MemberDto()
            {
                Name = name,
                Password = password,
                Phone = phone,
                Email = email,
                Address = address,
                Gender = gender,
                MemberLevelName = comboBoxMemberLevel.Text,
                CityName = comboBoxCity.Text,
                AreaName = comboBoxArea.Text,
                DateOfBirth = dateOfBirth.Value,
                RegisterDate = registerDate,
            };


            //service 驗證 呼叫service
            var service = new MemberService();


            try
            {
                //service 驗證 呼叫service

                service.Create(member);
                MessageBox.Show("新增會員成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonValidateEmail_Click(object sender, EventArgs e)
        {
            labelAlarm.Visible = false;

            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                var query = new MemberRepository().GetByEmail(textBoxEmail.Text);
                if (query != null)
                {
                    labelAlarm.Visible = true;
                    labelAlarm.Text = "信箱已被註冊!";
                    return;
                }
                else
                {
                    labelAlarm.Visible = true;
                    labelAlarm.Text = "信箱可使用!";
                    return;
                }

            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                labelAlarm.Visible = true;
                labelAlarm.Text = "信箱未填寫!";
                return;
            }


        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            labelAlarm.Visible = false;
        }
    }
}
