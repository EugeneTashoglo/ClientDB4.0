namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPhoto")]
    public partial class ProductPhoto
    {
        public int ProductPhotoID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(1000)]
        public string PhotoPath { get; set; }

        public virtual Product Product { get; set; }
    }
}
