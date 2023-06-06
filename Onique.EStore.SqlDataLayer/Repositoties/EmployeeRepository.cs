using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class EmployeeRepository
    {
        public List<EmployeeDto> Search(string s_Name, string s_Id)
        {
            var db = new AppDbContext();
            var query = from e in db.Employees
                        join c in db.Citys
                        on e.Citys equals c.CityId
                        join a in db.Areas
                        on e.Areas equals a.AreaId
                        join el in db.EmployeeLevels
                        on e.Position equals el.EmployeeLevelId
                        select new EmployeeDto
                        {
                            EmployeeId = e.EmployeeID,
                            EmployeeName = e.EmployeeName,
                            Password = e.Password,
                            Phone = e.Phone,
                            Email = e.Email,
                            Gender = e.Gender ? "女" : "男",
                            Citys = c.CityName,
                            Areas = a.AreaName,
                            Address = e.Address,
                            DateOfBirth = e.DateOfBirth,
                            Position = el.EmployeeLevelName,
                            PhotoPath = e.PhotoPath,
                            RegisterDate = e.RegisterDate,

                        };

            if (!string.IsNullOrEmpty(s_Name))
            {
                query = query.Where(e => e.EmployeeName.Contains(s_Name));
            }

            if (int.TryParse(s_Id, out int number))
            {
                query = query.Where(e => e.EmployeeId.Equals(number));
            }

            return query.ToList();
        }

        public EmployeeDto Get(int EmployeeId)
        {
            var db = new AppDbContext();
            var query = from e in db.Employees
                        join c in db.Citys
                        on e.Citys equals c.CityId
                        join a in db.Areas
                        on e.Areas equals a.AreaId
                        join el in db.EmployeeLevels
                        on e.Position equals el.EmployeeLevelId
                        select new EmployeeDto
                        {
                            EmployeeId = e.EmployeeID,
                            EmployeeName = e.EmployeeName,
                            Password = e.Password,
                            Phone = e.Phone,
                            Email = e.Email,
                            Gender = e.Gender ? "女" : "男",
                            Citys = c.CityName,
                            Areas = a.AreaName,
                            Address = e.Address,
                            DateOfBirth = e.DateOfBirth,
                            Position = el.EmployeeLevelName,
                            PhotoPath = e.PhotoPath,
                            RegisterDate = e.RegisterDate,

                        };

            query = query.Where(e => e.EmployeeId == EmployeeId);
            EmployeeDto data = query.FirstOrDefault();

            return data;
        }

        public EmployeeDto GetByPhone(EmployeeDto dto)
        {
            var db = new AppDbContext();
            var query = db.Employees
                .Where(e=>e.Phone== dto.Phone)
                .Select(e=>new EmployeeDto
                {
                    EmployeeId=e.EmployeeID,
                    Phone = e.Phone,
                });
            return query.FirstOrDefault();
        }

        public List<string> GetAllCityNames()
        {
            var db = new AppDbContext();
            var query = db.Citys.Select(c => c.CityName);
            return query.ToList();
        }

        public List<string> GetAreaNameOfCitys(string cityNames)
        {
            var db = new AppDbContext();
            int cityId = db.Citys.Where(c => c.CityName == cityNames)
                                 .Select(c => c.CityId).FirstOrDefault();
            var query = db.Areas.Where(a => a.CityId == cityId)
                                .Select(s => s.AreaName);
            return query.ToList();
        }

        public int GetAreaId(string areaName)
        {
            var db = new AppDbContext();
            int areaId = db.Areas.Where(a => a.AreaName == areaName)
                                   .Select(a => a.AreaId).FirstOrDefault();
            return areaId;
        }

        public int GetCityId(string cityName)
        {
            var db = new AppDbContext();
            int cityId = db.Citys.Where(a => a.CityName == cityName)
                                   .Select(a => a.CityId).FirstOrDefault();
            return cityId;
        }

        public void CreateEmployee(EmployeeDto dto)
        {

            bool gender = dto.Gender != "男" ? true : false;
            var db = new AppDbContext();
            int positionId = db.EmployeeLevels.Where(s => s.EmployeeLevelName == dto.Position).Select(s => s.EmployeeLevelId).FirstOrDefault(); var dtoInDb = new Employee()
            {
                EmployeeName = dto.EmployeeName,
                Password = dto.Password,
                Phone = dto.Phone,
                Email = dto.Email,
                Address = dto.Address,
                Position = positionId,
                Citys = GetCityId(dto.Citys),
                Areas = GetAreaId(dto.Areas),
                DateOfBirth = dto.DateOfBirth,
                RegisterDate = dto.RegisterDate,
                PhotoPath = dto.PhotoPath,
                Gender = gender,
            };

            db.Employees.Add(dtoInDb);
            db.SaveChanges();
        }

        public EmployeeDto GetEmployeeByEmail(EmployeeDto dto)
        {
            var db = new AppDbContext();
            var query = db.Employees.Where(x=>x.Email==dto.Email)
                .Select(x=>new EmployeeDto { Email=x.Email,EmployeeId=x.EmployeeID,Phone=x.Phone });
            return query.FirstOrDefault();
            
        }

        public List<string> GetPositionItems()
        {
            var db = new AppDbContext();
            var query = db.EmployeeLevels.Select(p => p.EmployeeLevelName);
            return query.ToList();
        }
    }
}
