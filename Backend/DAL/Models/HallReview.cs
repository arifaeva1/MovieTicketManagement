using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HallReview
    {
        [Key]
        public string ReviewId { get; set; }
        public string ReviewText { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("HallDetails")]
        public string ZoneCode { get; set; }
        public virtual HallDetails HallDetails { get; set; }
        
    }
}
