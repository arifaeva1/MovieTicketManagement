using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo1 : Repo, IRepo<HallStaff, string, HallStaff>
    {
        public HallStaff Create(HallStaff obj)
        {

            db.HallStaffs.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;

        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.HallStaffs.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<HallStaff> Read()
        {
            return db.HallStaffs.ToList();
        }

        public HallStaff Read(string id)
        {
            return db.HallStaffs.Find(id);
        }

        public HallStaff Update(HallStaff obj)
        {
            throw new NotImplementedException();
        }
    }
}