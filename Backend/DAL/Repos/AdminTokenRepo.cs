using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminTokenRepo : Repo, IRepo<AdminToken, string, AdminToken>
    {
        public AdminToken Create(AdminToken obj)
        {
            db.AdminTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<AdminToken> Read()
        {
            throw new NotImplementedException();
        }

        public AdminToken Read(string id)
        {
            return db.AdminTokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public AdminToken Update(AdminToken obj)
        {
            var token = Read(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;
        }
    }
}
