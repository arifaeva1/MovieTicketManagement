using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class HallDetails
    {
        [Key]
        public string ZoneCode { get; set; }
        [Required]
        [StringLength(50)]
        public string ZoneName { get; set; }
        [Required]
        [StringLength(50)]
        public string ZonePlace { get; set; }
        [Required]

        public int SitCount { get; set; }


        //[ForeignKey("HallRepresenter")]
        //public int UpdatedBy { get; set; }
        //public virtual HallRepresenter HallRepresenter { get; set; }

         public virtual ICollection<HallReview> HallReviews { get; set; }

        public HallDetails()
        {
            
            HallReviews = new List<HallReview>();

        }

    }
}
