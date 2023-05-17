using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminDTO
    {
        public string Aname { get; set; }
        [Required]

        public string AdminName { get; set; }
        [Required]
        public string AdminPassword { get; set; }
        public string Type { get; set; }
    }
}
