namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MENUITEMVARIANTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MENUITEMVARIANTS()
        {
            ORDERITEMS = new HashSet<ORDERITEMS>();
        }

        public int ID { get; set; }

        public int MENUITEM_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        public decimal? EXTRA_PRICE { get; set; }

        public bool? IS_AVAILABLE { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual MENUITEMS MENUITEMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERITEMS> ORDERITEMS { get; set; }
    }
}
