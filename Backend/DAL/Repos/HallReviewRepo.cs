using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HallReviewRepo : Repo, IRepo<HallReview, string, HallReview>
    {
        public HallReview Create(HallReview obj)
        {
            db.HallReviews.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.HallReviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<HallReview> Read()
        {
            return db.HallReviews.ToList();
        }

        public HallReview Read(string id)
        {
            return db.HallReviews.Find(id);
        }

        public HallReview Update(HallReview obj)
        {
            var ex = Read(obj.ReviewId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
