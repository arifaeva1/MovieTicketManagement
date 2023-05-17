using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HallRepresenterRepo : Repo, IRepo<HallRepresenter, int, HallRepresenter>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.HallRepresenters.FirstOrDefault(u => u.Id.Equals(username) &&
           u.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public HallRepresenter Create(HallRepresenter obj)
        {
            db.HallRepresenters.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<HallRepresenter> Read()
        {
            return db.HallRepresenters.ToList();
        }

        public HallRepresenter Read(int id)
        {
            return db.HallRepresenters.Find(id);
        }

        public HallRepresenter Update(HallRepresenter obj)
        {
            var ex = Read(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }
    }
}
