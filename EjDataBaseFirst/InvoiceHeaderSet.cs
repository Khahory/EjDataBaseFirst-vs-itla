namespace EjDataBaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceHeaderSet")]
    public partial class InvoiceHeaderSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceHeaderSet()
        {
            InvoiceDetailSet = new HashSet<InvoiceDetailSet>();
        }

        [Key]
        public int InvoiceHeader_Id { get; set; }

        public decimal Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetailSet> InvoiceDetailSet { get; set; }
    }
}
