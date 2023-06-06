using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class MemberDto
    {

        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string CityName { get; set; }
        public string AreaName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MemberLevelName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PhotoPath { get; set; }


    }
}
