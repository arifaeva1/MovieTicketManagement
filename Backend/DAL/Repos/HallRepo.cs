using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HallRepo : Repo, IRepo<Hall, string, Hall>
    {
        public Hall Create(Hall obj)
        {
            db.Halls.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Halls.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Hall> Read()
        {
            return db.Halls.ToList();
        }

        public Hall Read(string id)
        {
            return db.Halls.Find(id);
        }

        public Hall Update(Hall obj)
        {
            var ex = Read(obj.HallId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
