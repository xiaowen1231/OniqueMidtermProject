using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string ShippingMethod { get; set; }
        public string Address { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Discount { get; set; }
    }
}
