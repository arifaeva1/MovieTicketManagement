﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, string, Admin>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.Admins.FirstOrDefault(u => u.Aname.Equals(username) &&
            u.AdminPassword.Equals(password));
            if (data != null) return true;
            return false;
        }

        public Admin Create(Admin obj)
        {
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Read()
        {
            return db.Admins.ToList();
        }

        public Admin Read(string id)
        {
            return db.Admins.Find(id);
        }

        public Admin Update(Admin obj)
        {
            var ex = Read(obj.Aname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

    }
}