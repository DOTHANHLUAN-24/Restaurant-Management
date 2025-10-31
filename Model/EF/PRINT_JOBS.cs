namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRINT_JOBS
    {
        public int ID { get; set; }

        public int? ORDER_ID { get; set; }

        public byte TYPE { get; set; }

        [Required]
        public string PAYLOAD { get; set; }

        [Required]
        [StringLength(100)]
        public string PRINTER_ID { get; set; }

        public byte STATUS { get; set; }

        public short? ATTEMPTS { get; set; }

        [StringLength(500)]
        public string ERROR_MESSAGE { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? PROCESSED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual ORDERS ORDERS { get; set; }
    }
}
