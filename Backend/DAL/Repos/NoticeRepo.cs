using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NoticeRepo : Repo, IRepo<Notice, int, Notice>
    {
        public Notice Create(Notice obj)
        {
            db.Notices.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = db.Notices.Find(id);
            db.Notices.Remove(data);
            if (db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public List<Notice> Read()
        {
            return db.Notices.ToList();
        }

        public Notice Read(int id)
        {
            return db.Notices.Find(id);
        }

        public Notice Update(Notice obj)
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
