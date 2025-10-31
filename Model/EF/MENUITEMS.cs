namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MENUITEMS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MENUITEMS()
        {
            MENUITEMVARIANTS = new HashSet<MENUITEMVARIANTS>();
            ORDERITEMS = new HashSet<ORDERITEMS>();
        }

        public int ID { get; set; }

        public int RESTAURANT_ID { get; set; }

        public int CATEGORY_ID { get; set; }

        public int? STATION_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "money")]
        public decimal PRICE { get; set; }

        public bool? IS_AVAILABLE { get; set; }

        public short? ETA_MIN { get; set; }

        public short? ETA_MAX { get; set; }

        public string TAGS { get; set; }

        [StringLength(500)]
        public string IMAGE_URL { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual CATEGORIES CATEGORIES { get; set; }

        public virtual RESTAURANTS RESTAURANTS { get; set; }

        public virtual STATIONS STATIONS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENUITEMVARIANTS> MENUITEMVARIANTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERITEMS> ORDERITEMS { get; set; }
    }
}
