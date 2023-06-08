using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCategoryName { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public DateTime AddedTime { get; set; }

        public DateTime ShelfTime { get; set; }

        public string SupplierId { get; set; }

        public string SizeName { get; set; }
        public int SizeId { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public int PhotoId { get; set; }
    }
}
