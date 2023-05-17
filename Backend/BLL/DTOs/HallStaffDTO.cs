using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HallStaffDTO
    {


        public string HSname { get; set; }
        [Required]
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
        public string HallStaffPassword { get; set; }
        [Required]
        public int HallStaffNid { get; set; }
        [Required]
        public string Aname { get; set; }
    }
}
