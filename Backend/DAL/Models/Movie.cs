using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Movie
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string MovieTitle { get; set; }
        [Required]
        [StringLength(50)]

        public string Description { get; set; }
        [Required]
        [StringLength(50)]

        public string MovieTrailerLink { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("HallRepresenter")]
        public int AddBy { get; set; }
        public virtual HallRepresenter HallRepresenter { get; set; }

        public virtual ICollection<Ticket> Movies { get; set; }
        public virtual ICollection<MovieRating> MovieRatings { get; set; }

        public Movie()
        {
          Movies = new List<Ticket>();
          MovieRatings = new List<MovieRating>();
        }
       
        
    }
}
