namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            order_item = new HashSet<order_item>();
        }

        [Key]
        public int order_id { get; set; }

        public int? user_id { get; set; }

        public DateTime? buy_date { get; set; }

        public double? total_price { get; set; }

        [StringLength(100)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_item> order_item { get; set; }

        public virtual user_account user_account { get; set; }
    }
}
