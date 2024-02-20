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
        [StringLength(50)]
        public string ClientID { get; set; }

        [StringLength(100)]
        public string ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        public string Comment { get; set; }

        public int id { get; set; }

        public virtual Client Client { get; set; }

        public virtual Service Service { get; set; }
    }
}
