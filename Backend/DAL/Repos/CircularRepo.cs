using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CircularRepo : Repo, IRepo<Circular, string, Circular>
    {
        public Circular Create(Circular obj)
        {
            db.Circulars.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(string id)
        {
            var data = db.Circulars.Find(id);
            db.Circulars.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Circular> Read()
        {
            return db.Circulars.ToList();
        }

        public Circular Read(string id)
        {
            return db.Circulars.Find(id);
        }

        public Circular Update(Circular obj)
        {
            var data = Read(obj.ID);
            db.Entry(data).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
