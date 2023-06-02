using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class OrderDetailProductDto
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public string SizeName { get; set; }
        public int OrderQuantity { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public string PhotoPath { get; set; }
        public decimal Price { get; set; }
    }
}
