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

        public int customerId { get; set; }

        public int userId { get; set; }

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

        public DateTime createDate { get; set; }

        [Required]
        [StringLength(40)]
        public string createdBy { get; set; }

        public DateTime lastUpdate { get; set; }

        [Required]
        [StringLength(40)]
        public string lastUpdateBy { get; set; }

        public virtual customer customer { get; set; }

        public virtual user user { get; set; }
    }
}
