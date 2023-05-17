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
    public class MovieRatingService
    {
        public static List<MovieRatingDTO> Get()
        {
            var data = DataAccessFactory.RatingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MovieRating, MovieRatingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<MovieRatingDTO>>(data);
            return mapped;
        }
        public static MovieRatingDTO Get(string id)
        {
            var data = DataAccessFactory.RatingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MovieRating, MovieRatingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<MovieRatingDTO>(data);
            return mapped;
        }



        public static MovieRatingDTO Create(MovieRatingDTO movierating)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<MovieRatingDTO, MovieRating>();
                c.CreateMap<MovieRating, MovieRatingDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<MovieRating>(movierating);
            var data = DataAccessFactory.RatingData().Create(ht);


            if (data != null)
                return mapper.Map<MovieRatingDTO>(data);
            return null;
        }


        public static MovieRatingDTO Update(MovieRatingDTO movieratingDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<MovieRatingDTO, MovieRating>();
                c.CreateMap<MovieRating, MovieRatingDTO>();
            });
            var mapper = new Mapper(cfg);
            var movierating = mapper.Map<MovieRating>(movieratingDTO);
            var data = DataAccessFactory.RatingData().Update(movierating);
            if (data != null)
            {
                return mapper.Map<MovieRatingDTO>(data);
            }
            return null;
        }



        public static bool Delete(string id)
        {

            var result = DataAccessFactory.RatingData().Delete(id);
            return result;

        }
    }
}
