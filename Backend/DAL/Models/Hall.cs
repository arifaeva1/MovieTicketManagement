using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Hall
    {
        [Key]
        public string HallId { get; set; }
        [Required]
        public string HallName { get; set; }
        [Required]
        public string Location { get; set; }

        [ForeignKey("Admin")]
        public string Aname { get; set; }

        public virtual Admin Admin { get; set; }


    }
}