namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentByService")]
    public partial class DocumentByService
    {
        [Key]
        public int DocID { get; set; }

        public int ClientServiceID { get; set; }

        [Required]
        [StringLength(1000)]
        public string DocumentPath { get; set; }

        public virtual ClientService ClientService { get; set; }
    }
}
