namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientService")]
    public partial class ClientService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientService()
        {
            DocumentByService = new HashSet<DocumentByService>();
        }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        public string Comment { get; set; }

        public int ClientServiceID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentByService> DocumentByService { get; set; }
    }
}
