namespace SoftwareIIb
{
    using SoftwareIIb.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer : AModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            appointments = new HashSet<appointment>();
        }

        [Key]
        public int customerId { get; set; }

        [Required]
        [StringLength(45)]
        public string customerName { get; set; }

        public int addressId { get; set; }

        public bool active { get; set; }

        public virtual address address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
    }
}
