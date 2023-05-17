using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public string Aname { get; set; }
        [Required]
        [StringLength(30)]
        public string AdminName { get; set; }
        [Required]
        [StringLength(20)]
        public string AdminPassword { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<HallStaff> HallStaffs { get; set; }
        public virtual ICollection<Hall> Halls { get; set; }

        public Admin()
        {
            HallStaffs = new List<HallStaff>();
            Halls = new List<Hall>();

        }


    }
}
