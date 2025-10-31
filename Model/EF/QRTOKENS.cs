namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QRTOKENS
    {
        public int ID { get; set; }

        public int TABLE_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string TOKEN { get; set; }

        [StringLength(500)]
        public string URL { get; set; }

        public DateTime? EXPIRES_AT { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual TABLES TABLES { get; set; }
    }
}
