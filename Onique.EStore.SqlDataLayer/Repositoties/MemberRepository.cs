using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class MemberRepository
    {

        public List<MemberDto> Search(string s_Name, string s_Phone)
        {


            var db = new AppDbContext();
            var data = from m in db.Members.AsNoTracking()
                       join c in db.Citys.AsNoTracking() on m.Citys equals c.CityId
                       join a in db.Areas.AsNoTracking() on m.Areas equals a.AreaId
                       join ml in db.MemberLevels.AsNoTracking() on m.MemberLevel equals ml.MemberLevelId
                       select new MemberDto//轉型成dto
                       {
                           MemberId = m.MemberId,
                           Name = m.Name,
                           Password = m.Password,
                           Phone = m.Phone,
                           Email = m.Email,
                           Gender = m.Gender ? "女" : "男",
                           MemberLevelName = ml.MemberLevelName,
                           CityName = c.CityName,
                           AreaName = a.AreaName,
                           Address = m.Address,
                           DateOfBirth = (DateTime)m.DateOfBirth,
                           RegisterDate = (DateTime)m.RegisterDate,
                           PhotoPath = m.PhotoPath

                       };

            if (!string.IsNullOrEmpty(s_Name))
            {
                data = data.Where(m => m.Name.Contains(s_Name));
            }
            if (!string.IsNullOrEmpty(s_Phone))
            {
                data = data.Where(m => m.Phone.Contains(s_Phone));
            }
            return data.ToList();
        }
        public MemberDto Get(int MemberId)
        {
            var db = new AppDbContext();
            var query = (from m in db.Members.AsNoTracking()
                         join c in db.Citys.AsNoTracking() on m.Citys equals c.CityId
                         join a in db.Areas.AsNoTracking() on m.Areas equals a.AreaId
                         join ml in db.MemberLevels.AsNoTracking() on m.MemberLevel equals ml.MemberLevelId


                         select new MemberDto//轉型成dto iqueryable<memberdto>
                         {
                             MemberId = m.MemberId,
                             Name = m.Name,
                             Password = m.Password,
                             Phone = m.Phone,
                             Email = m.Email,
                             Gender = m.Gender ? "女" : "男",
                             MemberLevelName = ml.MemberLevelName,
                             CityName = c.CityName,
                             AreaName = a.AreaName,
                             Address = m.Address,
                             DateOfBirth = (DateTime)m.DateOfBirth,
                             RegisterDate = (DateTime)m.RegisterDate,
                             PhotoPath = m.PhotoPath
                         });
            query = query.Where(m => m.MemberId == MemberId);
            MemberDto data = query.FirstOrDefault();
            return data;

        }

        public List<string> GetAllCity()
        {
            var db = new AppDbContext();
            var query = db.Citys.AsNoTracking().Select(c => c.CityName);

            return query.ToList();
        }

        public List<string> GetAreaOfCity(string cityName)
        {
            var db = new AppDbContext();
            int cityId = db.Citys.AsNoTracking().Where(c => c.CityName == cityName)
                .Select(i => i.CityId).FirstOrDefault();
            var query = db.Areas.AsNoTracking().Where(a => a.CityId == cityId)
                .Select(n => n.AreaName);
            return query.ToList();
        }

        public int GetAreaId(string areaName)
        {
            var db = new AppDbContext();
            int areaId = db.Areas.AsNoTracking().Where(a => a.AreaName == areaName)
                .Select(n => n.AreaId).FirstOrDefault();
            return areaId;
        }
        public int GetCityId(string cityName)
        {
            var db = new AppDbContext();
            int cityId = db.Citys.AsNoTracking().Where(c => c.CityName == cityName)
                .Select(n => n.CityId).FirstOrDefault();
            return cityId;
        }
        public int GetMemberLevelId(string memberLevelName)
        {
            var db = new AppDbContext();
            int memberlevelid = db.MemberLevels.AsNoTracking().Where(ml => ml.MemberLevelName == memberLevelName)
                .Select(ml => ml.MemberLevelId).FirstOrDefault();
            return memberlevelid;
        }
        public MemberDto GetByPhone(MemberDto dto)
        {
            return new AppDbContext().Members.Where(m => m.Phone == dto.Phone).Select(m =>
                new MemberDto
                {
                    Phone = m.Phone,
                    MemberId = m.MemberId,
                }
                ).FirstOrDefault();
        }
        public string GetByEmail(string s_email)//找看看有沒有相同ㄉemail,回傳email
        {
            var db = new AppDbContext();
            var data = db.Members.AsNoTracking().Where(m => m.Email == s_email).Select(m => m.Email)
                .FirstOrDefault();

            return data;

        }

        public void Create(MemberDto dto)
        {

            var db = new AppDbContext();
            var member = new Member()
            {
                Name = dto.Name,
                Password = dto.Password,
                Phone = dto.Phone,
                Email = dto.Email,
                Address = dto.Address,
                MemberLevel = GetMemberLevelId(dto.MemberLevelName),
                Citys = GetCityId(dto.CityName),
                Areas = GetAreaId(dto.AreaName),
                DateOfBirth = dto.DateOfBirth,
                RegisterDate = dto.RegisterDate
            };
            db.Members.Add(member);
            db.SaveChanges();
        }
        public void Update(MemberDto dto)
        {

            var db = new AppDbContext();
            var member = new Member()
            {
                Name = dto.Name,
                Password = dto.Password,
                Phone = dto.Phone,
                Email = dto.Email,
                Address = dto.Address,
                MemberLevel = GetMemberLevelId(dto.MemberLevelName),
                Citys = GetCityId(dto.CityName),
                Areas = GetAreaId(dto.AreaName),
                DateOfBirth = dto.DateOfBirth,
                RegisterDate = dto.RegisterDate
            };

            db.SaveChanges();
        }

    }
}
