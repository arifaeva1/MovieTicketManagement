using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MovieDTO
    {

        public int Id { get; set; }

        public string MovieTitle { get; set; }


        public string Description { get; set; }


        public string MovieTrailerLink { get; set; }

        public DateTime Date { get; set; }


        public int AddBy { get; set; }
    }
}
