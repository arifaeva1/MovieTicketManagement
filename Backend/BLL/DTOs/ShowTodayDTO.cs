using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ShowTodayDTO
    {
        public int Serial { get; set; }
        public int MovieId { get; set; }

        public string MovieTitle { get; set; }

        public string ScrenType { get; set; }

        public DateTime Time { get; set; }


        public int AddBy { get; set; }

    }
}