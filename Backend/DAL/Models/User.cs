using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        [Required] 
        public string UserName { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string UserAddress { get; set; }

        [Required]
        public int UserPhone { get; set; }

        [Required]
        public string UserGender { get; set; }

        [Required]
        [StringLength(20)]
        public string UserPassword { get; set; }

        public string Type { get; set; } 

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<HallReview> HallReviews { get; set; }
        public virtual ICollection<MovieRating> MovieRatings { get; set; }
        public virtual ICollection<TicketHistory> TicketHistorys { get; set; }

        public User()
        {
            Tickets = new List<Ticket>();
            HallReviews = new List<HallReview>();
            MovieRatings = new List<MovieRating>();
            TicketHistorys= new List<TicketHistory>();

        }


    }
}
