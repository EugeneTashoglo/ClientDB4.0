namespace ClientDB4._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagOfClient")]
    public partial class TagOfClient
    {
        [StringLength(50)]
        public string LastName { get; set; }

        public int? TagID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTagOfClient { get; set; }

        public virtual Client Client { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
