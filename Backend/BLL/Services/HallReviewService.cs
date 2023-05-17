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
    public class HallReviewService
    {
        public static HallReviewDTO Create(HallReviewDTO hallreview)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HallReviewDTO, HallReview>();
                c.CreateMap<HallReview, HallReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<HallReview>(hallreview);
            var data = DataAccessFactory.ReviewData().Create(ht);


            if (data != null)
                return mapper.Map<HallReviewDTO>(data);
            return null;
        }

        public static HallReviewDTO Update(HallReviewDTO hallreviewDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HallReviewDTO, HallReview>();
                c.CreateMap<HallReview, HallReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var hallreview = mapper.Map<HallReview>(hallreviewDTO);
            var data = DataAccessFactory.ReviewData().Update(hallreview);
            if (data != null)
            {
                return mapper.Map<HallReviewDTO>(data);
            }
            return null;
        }

        public static bool Delete(string id)
        {

            var result = DataAccessFactory.ReviewData().Delete(id);
            return result;

        }

        public static List<HallReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallReview, HallReviewDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HallReviewDTO>>(data);
            return mapped;
        }
        public static HallReviewDTO Get(string id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallReview, HallReviewDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HallReviewDTO>(data);
            return mapped;
        }
    }
}
