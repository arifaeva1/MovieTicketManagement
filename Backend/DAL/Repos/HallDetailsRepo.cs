using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HallDetailsRepo : Repo, IRepo<HallDetails, string, HallDetails>
    {
        public HallDetails Create(HallDetails obj)
        {
            db.HallDetailss.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(string code)
        {
            var data = Read(code);
            db.HallDetailss.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<HallDetails> Read()
        {
            return db.HallDetailss.ToList();
        }

        public HallDetails Read(string code)
        {
            return db.HallDetailss.Find(code);
        }

        public HallDetails Update(HallDetails obj)
        {
            var ex = Read(obj.ZoneCode);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
