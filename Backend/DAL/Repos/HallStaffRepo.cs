using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HallStaffRepo : Repo, IRepo<HallStaff, string, HallStaff>
    {
        public HallStaff Create(HallStaff obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<HallStaff> Read()
        {
            throw new NotImplementedException();
        }

        public HallStaff Read(string id)
        {
            throw new NotImplementedException();
        }

        public HallStaff Update(HallStaff obj)
        {
            throw new NotImplementedException();
        }
    }
}
