using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TicketHistoryDTO
    {
        
        public string HistoryId { get; set; }
        public int HistoryStatus { get; set; }
        public int TotalAmount { get; set; }
        public string UserId { get; set; }
        public string TicketId { get; set; }
    }
}
