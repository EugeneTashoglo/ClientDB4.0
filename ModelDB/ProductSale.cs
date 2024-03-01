namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        [Key]
        public int SaleID { get; set; }

        public DateTime SaleDate { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int? ClientServiceID { get; set; }

        public virtual Product Product { get; set; }
    }
}
