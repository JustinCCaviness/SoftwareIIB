using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.DAL.Models
{
    public abstract class AModel
    {
        [Required]
        [StringLength(40)]
        public string createdBy { get; set; }

        public DateTime lastUpdate { get; set; }

        [Required]
        [StringLength(40)]
        public string lastUpdateBy { get; set; }


        public DateTime createDate { get; set; }
    }
}
