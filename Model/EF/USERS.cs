namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            AUDIT_LOGS = new HashSet<AUDIT_LOGS>();
            RECEIPTS = new HashSet<RECEIPTS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string USERNAME { get; set; }

        [StringLength(255)]
        public string FULL_NAME { get; set; }

        [StringLength(255)]
        public string PASSWORD_HASH { get; set; }

        public int ROLE_ID { get; set; }

        public int RESTAURANT_ID { get; set; }

        public bool? IS_ACTIVE { get; set; }

        public DateTime? LAST_LOGIN_AT { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUDIT_LOGS> AUDIT_LOGS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEIPTS> RECEIPTS { get; set; }

        public virtual RESTAURANTS RESTAURANTS { get; set; }

        public virtual ROLES ROLES { get; set; }
    }
}
