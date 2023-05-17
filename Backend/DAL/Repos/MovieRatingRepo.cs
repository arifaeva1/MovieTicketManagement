using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MovieRatingRepo : Repo, IRepo<MovieRating, string, MovieRating>
    {
        public MovieRating Create(MovieRating obj)
        {
            db.MovieRatings.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.MovieRatings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<MovieRating> Read()
        {
            return db.MovieRatings.ToList();
        }

        public MovieRating Read(string id)
        {
            return db.MovieRatings.Find(id);
        }

        public MovieRating Update(MovieRating obj)
        {
            var ex = Read(obj.RatingId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
