using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ShowTodayRepo : Repo, IRepo<ShowToday, int, ShowToday>
    {
        public ShowToday Create(ShowToday obj)
        {
            db.showTodays.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = Read(id);
            db.showTodays.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<ShowToday> Read()
        {
            return db.showTodays.ToList();
        }

        public ShowToday Read(int id)
        {
            return db.showTodays.Find(id);
        }

        public ShowToday Update(ShowToday obj)
        {
            var ex = Read(obj.MovieId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
