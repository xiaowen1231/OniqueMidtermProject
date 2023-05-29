namespace Onique.EStore.SqlDataLayer.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPhotos")]
    public partial class ProductPhoto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductPhoto()
        {
            ProductStockDetails = new HashSet<ProductStockDetail>();
        }

        public int ProductPhotoId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductPhotoName { get; set; }

        [Required]
        [StringLength(250)]
        public string ProductPhotoPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductStockDetail> ProductStockDetails { get; set; }
    }
}
