namespace EjDataBaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceDetailSet")]
    public partial class InvoiceDetailSet
    {
        [Key]
        public int InvoiceDetail_Id { get; set; }

        [Required]
        public string ItemDescriptions { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int InvoiceHeaderInvoiceHeader_Id { get; set; }

        public virtual InvoiceHeaderSet InvoiceHeaderSet { get; set; }
    }
}
