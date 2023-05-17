using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MovieRatingDTO
    {
        public string RatingId { get; set; }
        public string RatingText { get; set; }    
        public string UserId { get; set; }
        public int Id { get; set; }
        
    }
}
