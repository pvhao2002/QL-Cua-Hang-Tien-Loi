namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order_item
    {
        [Key]
        public int order_item_id { get; set; }

        public int? order_id { get; set; }

        public int? product_id { get; set; }

        public int? quantity { get; set; }

        public double? total_price_item { get; set; }

        public virtual order order { get; set; }

        public virtual product product { get; set; }
    }
}
