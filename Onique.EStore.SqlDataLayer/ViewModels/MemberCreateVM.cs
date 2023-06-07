using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Onique.EStore.SqlDataLayer.ViewModels
{
    public class MemberCreateVM
    {
        [Display(Name = "會員編號")]
        public int MemberId { get; set; }



        [Display(Name = "會員姓名")]
        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
        public string Name { get; set; }



        [Display(Name = "密碼")]
        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(20, ErrorMessage = "{0}長度不可大於{1}")]
        public string Password { get; set; }



        [Display(Name = "手機號碼")]
        [Required(ErrorMessage = "{0}必填")]
        [StringLength(10, ErrorMessage = "{0}填寫錯誤")]
        public string Phone { get; set; }



        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0}必填")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50, ErrorMessage = "{0}長度不可大於{1}")]
        public string Email { get; set; }



        [Display(Name = "性別")]
        [Required(ErrorMessage = "{0}必填")]
        public bool Gender { get; set; }




        [Required]
        public string CityName { get; set; }





        [Required]
        public string AreaName { get; set; }





        public string Address { get; set; }
        [Display(Name = "出生日期")]

        public DateTime? DateOfBirth { get; set; }



        [Required]
        public string MemberLevelName { get; set; }



        [Required]
        [Display(Name = "註冊日期")]
        public DateTime? RegisterDate { get; set; }



        public string PhotoPath { get; set; }

    }
}
