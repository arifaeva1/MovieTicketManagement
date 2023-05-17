using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BlockUser : Repo, IBlockUser<User, string>
    {
        public List<User> ActiveGet()
        {
            var AD = (from I in db.Users where I.Type.Equals("User") select I).ToList();
            return AD;
        }

        public User ActiveGet(string id)
        {
            throw new NotImplementedException();
        }

        public bool Block(string obj)
        {
            var AD = (from I in db.Users where I.UserId.Equals(obj) select I).FirstOrDefault();
            AD.Type = "Block";
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> BlockGet()
        {
            var AD = (from I in db.Users where I.Type.Equals("Block") select I).ToList();
            return AD;
        }

        public User BlockGet(string id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
