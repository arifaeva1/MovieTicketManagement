using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MovieRating
    {
        [Key]
        public string RatingId { get; set; }
        public string RatingText { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Movie")]
        public int Id { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
