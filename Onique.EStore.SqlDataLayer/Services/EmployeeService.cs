using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Services
{
    public class EmployeeService
    {
        public void CreateCheck(EmployeeDto dto)
        {
            //precondition checks, 檢查各欄位值是否有填寫正確
            if (string.IsNullOrEmpty(dto.Email))
            {
                throw new Exception("信箱尚未填寫 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.EmployeeName))
            {
                throw new Exception("姓名尚未填寫 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.Password))
            {
                throw new Exception("密碼尚未填寫 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.Phone))
            {
                throw new Exception("電話尚未填寫 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.Position))
            {
                throw new Exception("身分尚未選擇 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.Citys))
            {
                throw new Exception("縣市尚未選擇 ! 無法新增資料!");

            }

            if (string.IsNullOrEmpty(dto.Areas) || dto.Areas == "請選擇")
            {
                throw new Exception("地區尚未選擇 ! 無法新增資料!");

            }

            // 驗證分類名稱是否有重覆
            var repo = new EmployeeRepository();
            var dtoInDb = repo.GetByPhone(dto);
            var dtoInDbByEmail = repo.GetEmployeeByEmail(dto);
            if (dtoInDbByEmail != null) { 
            {
                if (!string.IsNullOrEmpty(dtoInDbByEmail.Email))
                {
                    throw new Exception("已有此信箱");
                }
            }
            }
            if (dtoInDb != null)
            {
                throw new Exception("抱歉, 此電話已存在,無法新增");
            }

            // 建立一筆新記錄
            repo.CreateEmployee(dto);
        }
    }
}
