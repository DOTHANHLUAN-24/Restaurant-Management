namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECEIPTS
    {
        public int ID { get; set; }

        public int ORDER_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string RECEIPT_NUMBER { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(50)]
        public string METHOD { get; set; }

        public int ISSUED_BY { get; set; }

        public DateTime? ISSUED_AT { get; set; }

        [Required]
        public string DETAILTS { get; set; }

        public virtual ORDERS ORDERS { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
