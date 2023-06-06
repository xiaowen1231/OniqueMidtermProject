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
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    int displayOrder = int.Parse(reader["displayOrder"].ToString());

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
