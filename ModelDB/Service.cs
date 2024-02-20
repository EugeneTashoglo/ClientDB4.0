namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            ClientService = new HashSet<ClientService>();
        }

        [Key]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        public int DurationInSeconds { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Discount { get; set; }

        [StringLength(1000)]
        public string MainImagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
    }
}
