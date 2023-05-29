namespace Onique.EStore.SqlDataLayer.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }

        public int MemberId { get; set; }

        public int MethodId { get; set; }

        [Required]
        [StringLength(250)]
        public string ShippingAddress { get; set; }

        public int OrderStatusId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public int PaymentMethodId { get; set; }

        public int? DiscountId { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual Member Member { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
