namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDERS()
        {
            ORDERITEMS = new HashSet<ORDERITEMS>();
            PAYMENTS = new HashSet<PAYMENTS>();
            PRINT_JOBS = new HashSet<PRINT_JOBS>();
            RECEIPTS = new HashSet<RECEIPTS>();
        }

        public int ID { get; set; }

        public int RESTAURANT_ID { get; set; }

        public int TABLE_ID { get; set; }

        [StringLength(255)]
        public string ORDER_TOKEN { get; set; }

        public byte STATUS { get; set; }

        public decimal TOTAL { get; set; }

        [StringLength(500)]
        public string GUEST_NOTE { get; set; }

        public byte PAYMENT_STATUS { get; set; }

        public int? CREATED_BY { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? CLOSED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERITEMS> ORDERITEMS { get; set; }

        public virtual RESTAURANTS RESTAURANTS { get; set; }

        public virtual TABLES TABLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAYMENTS> PAYMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRINT_JOBS> PRINT_JOBS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEIPTS> RECEIPTS { get; set; }
    }
}
