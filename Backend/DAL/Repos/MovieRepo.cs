using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MovieRepo : Repo, IRepo<Movie, int, Movie>
    {
        public Movie Create(Movie obj)
        {
            db.Movies.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var data = Read(id);
            db.Movies.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Movie> Read()
        {
            return db.Movies.ToList();
        }

        public Movie Read(int id)
        {
            return db.Movies.Find(id);
        }

        public Movie Update(Movie obj)
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
