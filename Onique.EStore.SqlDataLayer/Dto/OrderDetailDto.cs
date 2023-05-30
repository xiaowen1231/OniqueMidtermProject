using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }  
        public int OrderQuantity { get; set; }
        public string SizeName { get; set; }
        public string ColorName { get; set; }
    }
}
