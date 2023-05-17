using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Context: DbContext
    {
        public DbSet<User> Users { get; set; }

        //public DbSet<Movie> Movies { get; set; }

       

       

        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketHistory> TicketHistorys { get; set; }
        public DbSet<HallReview> HallReviews { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }






        public DbSet<AdminToken> AdminTokens { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<HallStaff> HallStaffs { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Circular> Circulars { get; set; }
        public DbSet<Notice> Notices { get; set; }









        public DbSet<HallRepresenter> HallRepresenters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<HallDetails> HallDetailss { get; set; }
        public DbSet<ShowToday> showTodays { get; set; }

        public DbSet<Token> Tokens { get; set; }




     
    }
}
