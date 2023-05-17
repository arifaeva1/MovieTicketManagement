using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HallStaff
    {

        [Key]
        public string HSname { get; set; }
        [Required]
        [StringLength(30)]
        public string HallStaffName { get; set; }
        [Required]
        public string HallStaffEmail { get; set; }
        [Required]
        public string HallStaffAddress { get; set; }
        [Required]
        public int HallStaffPhone { get; set; }
        [Required]
        public string HallStaffGender { get; set; }
        [Required]
        [StringLength(20)]
        public string HallStaffPassword { get; set; }
        [Required]
        public int HallStaffNid { get; set; }
        [ForeignKey("Admin")]
        public string Aname { get; set; }

        public virtual Admin Admin { get; set; }
    }
}