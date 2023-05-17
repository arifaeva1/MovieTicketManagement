using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TicketHistory
    {
        [Key]
        public string HistoryId { get; set; }
        public string HistoryStatus { get; set; }
        public int TotalAmount { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }

      //  [ForeignKey("Ticket")]
        public string TicketId { get; set; }
        //public virtual Ticket Ticket { get; set; }



    }
}
