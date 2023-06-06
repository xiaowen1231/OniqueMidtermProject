using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Onique.EStore.SqlDataLayer
{
    public class CategoryRepository
    {
        public CategoryDto Get(int categoryId)
        {
            string sql = $"select * from Categories where CategoryId = {categoryId}";

            Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;
            SqlParameter[] parameters = new SqlParameter[0];
            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.Get(connGetter, sql, func);
        }
        public CategoryDto GetByName(string name)
        {
            string sql = $"select * from Categories where Name =@Name";

            Func<SqlDataReader, CategoryDto> func = Assembler.CategoryDtoAssembler;
            SqlParameter parameter = new SqlParameter("@Name", SqlDbType.NVarChar, 30) { Value = name };
            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.Get(connGetter, sql, func, parameter);
        }
        public int Update(CategoryDto dto)
        {
            string sql = "update Categories set Name=@Name, DisplayOrder= @DisplayOrder where Id=@Id";

            var parameter = new SqlParameterBuilder()
                            .AddInt("@id", dto.CategoryId)
                            .AddNVarchar("@Name", 30, dto.CategoryName)
                            .AddInt("@DisplayOrder", dto.DisplayOrder)
                            .Build();
            Func<SqlConnection> connGetter = SqlDb.GetConnection;
            return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
        }
        public int Delete(int categoryId)
        {
            string sql = "delete from Categories where Id=@Id";
            SqlParameter parameter = new SqlParameter("@Id", SqlDbType.Int) { Value = categoryId };
            Func<SqlConnection> connGetter = SqlDb.GetConnection;

            return SqlDb.UpdateOrDelete(connGetter, sql, parameter);
        }
    }
}
