using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer
{
    public class CategoryService
    {
        public int Update(CategoryDto dto)
        {
            var repo = new CategoryRepository();
            var dtoInDb = repo.GetByName(dto.CategoryName);
            if (dtoInDb != null && dtoInDb.CategoryId != dto.CategoryId)
            {
                throw new Exception("抱歉，此分類名稱已存在，無法更新");
            }

            int rows = repo.Update(dto);
            return rows;
        }
    }
}
