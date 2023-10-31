namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            order_item = new HashSet<order_item>();
        }

        [Key]
        public int product_id { get; set; }

        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        [StringLength(1000)]
        public string image { get; set; }

        public double? price { get; set; }

        public int? stock { get; set; }

        [StringLength(100)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_item> order_item { get; set; }
    }
}
