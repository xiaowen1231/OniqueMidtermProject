using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Services
{
    public class MemberService
    {
        public void Create(MemberDto member)
        {
            var repo = new MemberRepository();
            var dtoInDb = repo.GetByPhone(member);
            var dtoInDbEmail = repo.GetByEmail(member.Email);

            if (dtoInDb != null)
            {
                throw new Exception("電話已被使用");
            }
            else if (dtoInDbEmail != null)
            {
                throw new Exception("已被使用");
            }
            repo.Create(member);


        }
        public void Update(MemberDto member)
        {
            var repo = new MemberRepository();
            var dtoInDb = repo.GetByPhone(member);

            if (dtoInDb != null && dtoInDb.MemberId != member.MemberId)
            {
                throw new Exception("電話已被使用");
            }
            repo.Update(member);
        }

    }
}
