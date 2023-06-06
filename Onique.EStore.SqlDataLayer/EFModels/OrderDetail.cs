namespace Onique.EStore.SqlDataLayer.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int OrderQuantity { get; set; }

        public int SizeId { get; set; }

        public int ColorId { get; set; }

        public virtual Order Order { get; set; }

        public virtual ProductColor ProductColor { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductSize ProductSize { get; set; }
    }
}
