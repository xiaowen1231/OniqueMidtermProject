using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class DiscountDto
    {
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountMethod { get; set; }

    }
}
