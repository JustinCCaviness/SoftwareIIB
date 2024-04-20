namespace SoftwareIIb
{
    using SoftwareIIb.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("address")]
    public partial class address : AModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public address()
        {
            customers = new HashSet<customer>();
        }

        [Key]
        public int addressId { get; set; }

        [Column("address")]
        [Required]
        [StringLength(50)]
        public string address1 { get; set; }

        [StringLength(50)]
        public string address2 { get; set; }

        public int cityId { get; set; }

        [Required]
        [StringLength(10)]
        public string postalCode { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        public virtual city city { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }
    }
}
