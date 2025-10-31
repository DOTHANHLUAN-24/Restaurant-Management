namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDERITEMS
    {
        public int ID { get; set; }

        public int ORDER_ID { get; set; }

        public int MENUITEM_ID { get; set; }

        public int? MENUITEMVARIANT_ID { get; set; }

        public short QUANTITY { get; set; }

        public decimal UNIT_PRICE { get; set; }

        public decimal LINE_TOTAL { get; set; }

        [StringLength(255)]
        public string NOTE { get; set; }

        public byte STATUS { get; set; }

        public int? ASSIGNED_TO { get; set; }

        public DateTime? STARTED_AT { get; set; }

        public DateTime? FINISHED_AT { get; set; }

        public DateTime? CREATED_AT { get; set; }

        public DateTime? UPDATED_AT { get; set; }

        public virtual MENUITEMS MENUITEMS { get; set; }

        public virtual MENUITEMVARIANTS MENUITEMVARIANTS { get; set; }

        public virtual ORDERS ORDERS { get; set; }
    }
}
