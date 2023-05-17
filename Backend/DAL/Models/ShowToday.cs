using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ShowToday
    {

        [Key]

        public int MovieId { get; set; }
        [Required]
        [StringLength(50)]
        public string MovieTitle { get; set; }

        [Required]
        [StringLength(50)]

        public string ScrenType { get; set; }

        public DateTime Time { get; set; }
        [ForeignKey("HallRepresenter")]
        public int AddBy { get; set; }
        public virtual HallRepresenter HallRepresenter { get; set; }
    }
}
