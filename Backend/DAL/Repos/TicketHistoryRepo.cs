using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketHistoryRepo : Repo, IRepo<TicketHistory, string, TicketHistory>
    {
        public TicketHistory Create(TicketHistory obj)
        {
            db.TicketHistorys.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }


        public bool Delete(string id)
        {
            var ex = Read(id);
            db.TicketHistorys.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<TicketHistory> Read()
        {
            return db.TicketHistorys.ToList();
        }

        public TicketHistory Read(string id)
        {
            return db.TicketHistorys.Find(id);
        }

        public TicketHistory Update(TicketHistory obj)
        {
            var ex = Read(obj.HistoryId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
