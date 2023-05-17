using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MovieService
    {
        public static List<MovieDTO> Get()
        {
            var data = DataAccessFactory.MovieDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Movie, MovieDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MovieDTO>>(data);
            return mapped;
        }
        public static MovieDTO Get(int Id)
        {
            var data = DataAccessFactory.MovieDataAccess().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Movie, MovieDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MovieDTO>(data);
            return mapped;
        }
        public static MovieDTO Add(MovieDTO movie)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MovieDTO, Movie>();
                c.CreateMap<Movie, MovieDTO>();
            }

            );

            var mapper = new Mapper(cfg);
            var moviee = mapper.Map<Movie>(movie);
            var data = DataAccessFactory.MovieDataAccess().Create(moviee);

            if (data != null)
            {
                return mapper.Map<MovieDTO>(data);
            }
            return null;
        }

        public static MovieDTO Update(MovieDTO movie)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<MovieDTO, Movie>();
                c.CreateMap<Movie, MovieDTO>();
            }
            );
            var mapper = new Mapper(cfg);
            var moviee = mapper.Map<Movie>(movie);
            var data = DataAccessFactory.MovieDataAccess().Update(moviee);
            if (data != null)
            {
                return mapper.Map<MovieDTO>(data);
            }
            return null;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.MovieDataAccess().Delete(id);
            return data;
        }
    }
}
