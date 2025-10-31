namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STATIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATIONS()
        {
            MENUITEMS = new HashSet<MENUITEMS>();
        }

        public int ID { get; set; }

        public int RESTAURANT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        public int? PRIORIRY { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENUITEMS> MENUITEMS { get; set; }

        public virtual RESTAURANTS RESTAURANTS { get; set; }
    }
}
