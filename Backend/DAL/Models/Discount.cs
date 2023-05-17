using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class Discount
    {

        [Key]
        public string DiscountId { get; set; }

        [Required]
        public string DCode { get; set; }

        [Required]
        public string Percentage { get; set; }
    }
}
