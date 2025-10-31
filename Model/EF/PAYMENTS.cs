namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAYMENTS
    {
        public int ID { get; set; }

        public int ORDER_ID { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(50)]
        public string METHOD { get; set; }

        [StringLength(50)]
        public string PROVIDER { get; set; }

        [StringLength(255)]
        public string PROVIDER_REF { get; set; }

        public byte STATUS { get; set; }

        public string REQUEST_PAYLOAD { get; set; }

        public string RESPONSE_PAYLOAD { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual ORDERS ORDERS { get; set; }
    }
}
