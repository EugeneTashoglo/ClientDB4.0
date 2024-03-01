namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductOfService")]
    public partial class ProductOfService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductOfServiceID { get; set; }

        [StringLength(100)]
        public string ServiceID { get; set; }

        public int? ProductID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Service Service { get; set; }
    }
}
