using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer
{
    public static class Assembler
    {
        public static Func<SqlDataReader, CategoryDto> CategoryDtoAssembler
        {
            get
            {
                Func<SqlDataReader, CategoryDto> func = (reader) =>
                {
                    int id = int.Parse(reader["CategoryId"].ToString());
                    string name = reader["CategoryName"].ToString();
                    int displayOrder = int.Parse(reader["DisplayOrder"].ToString());

                    return new CategoryDto
                    {
                        CategoryId = id,
                        CategoryName = name,
                        DisplayOrder = displayOrder,
                    };
                };
                return func;
            }
        }
    }
}
