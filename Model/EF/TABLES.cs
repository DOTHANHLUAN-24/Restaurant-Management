namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABLES()
        {
            ORDERS = new HashSet<ORDERS>();
            QRTOKENS = new HashSet<QRTOKENS>();
        }

        public int ID { get; set; }

        public int RESTAURANT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string NAME { get; set; }

        public int? SEATS { get; set; }

        [StringLength(50)]
        public string AREA { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERS> ORDERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QRTOKENS> QRTOKENS { get; set; }

        public virtual RESTAURANTS RESTAURANTS { get; set; }
    }
}
