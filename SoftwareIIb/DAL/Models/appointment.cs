namespace SoftwareIIb
{
    using SoftwareIIb.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("appointment")]
    public partial class appointment : AModel
    {
        [Key]
        public int appointmentId { get; set; }

        [Index("IDX_customerId")]
        public int? customerId { get; set; }

        [Index("IDX_userId")]
        public int? userId { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string location { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string type { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }

        [ForeignKey("customerId")]
        public virtual customer customer { get; set; }

        [ForeignKey("userId")]
        public virtual user user { get; set; }
    }
}
