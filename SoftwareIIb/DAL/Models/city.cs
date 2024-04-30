namespace SoftwareIIb
{
    using Microsoft.EntityFrameworkCore;
    using SoftwareIIb.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("city")]
    [Index(nameof(countryId), Name = "IDX_countryId")]
    public partial class city : AModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public city()
        {
            addresses = new HashSet<address>();
        }

        [Key]
        public int cityId { get; set; }

        [Column("city")]
        [Required]
        [StringLength(50)]
        public string city1 { get; set; }

        public int? countryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<address> addresses { get; set; }

        [ForeignKey("countryId")]
        public virtual country country { get; set; }
    }
}
