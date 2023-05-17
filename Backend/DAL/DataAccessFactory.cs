using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User,string,User> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<Movie, int, Movie> MovieData()
        {
            return new MovieRepo();
        }
       

        public static IRepo<HallStaff, string, HallStaff> HallStaffData()
        {
            return new AdminRepo1();
        }

        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }

        public static IRepo<UserToken,string,UserToken> UserTokenData()
        {
            return new UserTokenRepo();
        }
        public static IRepo<Ticket, string, Ticket> TicketData()
        {
            return new TicketRepo();
        }

        public static IRepo<TicketHistory, string, TicketHistory> TicketHistoryData()
        {
            return new TicketHistoryRepo();
        }

        public static IRepo<HallReview, string, HallReview> ReviewData()
        {
            return new HallReviewRepo();
        }
        public static IRepo<MovieRating, string, MovieRating> RatingData()
        {
            return new MovieRatingRepo();
        }






        public static IAuth<bool> AuthData1()
        {
            return new AdminRepo();
        }
        public static IRepo<Admin, string, Admin> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<AdminToken, string, AdminToken> AdminTokenData()
        {
            return new AdminTokenRepo();
        }

        public static IRepo<Hall, string, Hall> HallData()
        {
            return new HallRepo();
        }

        public static IRepo<Circular, string, Circular> CircularData()
        {
            return new CircularRepo();
        }
        public static IBlockUser<User, string> BlockUsertData()
        {
            return new BlockUser();
        }

        public static IActiveUser<User, string> ActiveUsertData()
        {
            return new ActiveUser();
        }

        public static IRepo<Notice, int, Notice> NoticeDataAccess()
        {
            return new NoticeRepo();
        }









        public static IRepo<HallRepresenter, int, HallRepresenter> HallRepresenterDataAccess()
        {
            return new HallRepresenterRepo();
        }
        public static IRepo<Movie, int, Movie> MovieDataAccess()
        {
            return new MovieRepo();
        }
        public static IRepo<HallDetails, string, HallDetails> HallDetailsDataAccess()
        {
            return new HallDetailsRepo();
        }
        public static IRepo<ShowToday, int, ShowToday> ShowTodaysDataAccess()
        {
            return new ShowTodayRepo();
        }

        public static IAuth<bool> AuthDataAccess()
        {
            return new HallRepresenterRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }








    }
}
