namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AUDIT_LOGS
    {
        public long ID { get; set; }

        public int? ACTOR_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ACTION { get; set; }

        [Required]
        [StringLength(50)]
        public string ENTITY { get; set; }

        public int ENTITY_ID { get; set; }

        public string OLD_VALUE { get; set; }

        public string NEW_VALUE { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        [StringLength(45)]
        public string IP_ADDRESS { get; set; }

        [StringLength(500)]
        public string USER_AGENT { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
