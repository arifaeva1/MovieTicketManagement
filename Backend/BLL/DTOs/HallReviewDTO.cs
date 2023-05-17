using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HallReviewDTO
    {
        public string ReviewId { get; set; }
        public string ReviewText { get; set; }

        public string UserId { get; set; }
        public string ZoneCode { get; set; }
    }
}
