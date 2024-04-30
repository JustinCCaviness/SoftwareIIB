namespace SoftwareIIb
{
    using Microsoft.EntityFrameworkCore;
    using SoftwareIIb.DAL.Attributes;
    using SoftwareIIb.DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("appointment")]
    [Index(nameof(customerId), Name = "IDX_customerId")]
    [Index(nameof(userId), Name = "IDX_userId")]
    public partial class appointment : AModel
    {
        [NotMapped]
        private DateTime _start;
        [NotMapped]
        private DateTime _end;

        [Key]
        public int appointmentId { get; set; }

        public int? customerId { get; set; }

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

        //[DateTimeKind(DateTimeKind.Utc)]
        public DateTime start
        {
            get
            {
                return _start;
                //switch (_start.Kind)
                //{
                //    case DateTimeKind.Unspecified:
                //        _start = DateTime.SpecifyKind(_end, DateTimeKind.Utc);
                //        break;
                //}
                //return _start.ToLocalTime();
            }
            set
            {
                _start = value;
                //if (value.Kind == DateTimeKind.Unspecified)
                //{
                //    value = DateTime.SpecifyKind(value, DateTimeKind.Local);
                //}
                //_start = value.ToUniversalTime();
            }
        }

        //[DateTimeKind(DateTimeKind.Utc)]
        public DateTime end {
            get {
                return _end;
                //switch (_end.Kind)
                //{
                //    case DateTimeKind.Unspecified:
                //        _end = DateTime.SpecifyKind(_end, DateTimeKind.Utc);
                //        break;
                //}
                //return _end.ToLocalTime();
            }
            set {
                _end = value;
                //if (value.Kind == DateTimeKind.Unspecified)
                //{
                //    value = DateTime.SpecifyKind(value, DateTimeKind.Local);
                //}
                //_end = value.ToUniversalTime();
            }
        }

        [ForeignKey("customerId")]
        public virtual customer customer { get; set; }

        [ForeignKey("userId")]
        public virtual user user { get; set; }
    }
}
