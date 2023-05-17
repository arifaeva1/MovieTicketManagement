using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HallDetailsDTO
    {
        public string ZoneCode { get; set; }

        public string ZoneName { get; set; }

        public string ZonePlace { get; set; }

        public int SitCount { get; set; }
        public int UpdatedBy { get; set; }
    }
}
