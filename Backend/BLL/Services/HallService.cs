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
    public class HallService
    {
        public static HallDTO Create(HallDTO hall)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HallDTO, Hall>();
                c.CreateMap<Hall, HallDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Hall>(hall);
            var data = DataAccessFactory.HallData().Create(ht);

            if (data != null) return mapper.Map<HallDTO>(data);
            return null;
        }


        public static bool Delete(string id)
        {

            var result = DataAccessFactory.HallData().Delete(id);
            return result;

        }

        public static HallDTO Get(string id)
        {
            var data = DataAccessFactory.HallData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hall, HallDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HallDTO>(data);
            return mapped;
        }
        public static List<HallDTO> Get()
        {
            var data = DataAccessFactory.HallData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hall, HallDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HallDTO>>(data);
            return mapped;
        }
        public static HallDTO Update(HallDTO hallDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HallDTO, Hall>();
                c.CreateMap<Hall, HallDTO>();
            });
            var mapper = new Mapper(cfg);
            var hall = mapper.Map<Hall>(hallDTO);
            var data = DataAccessFactory.HallData().Update(hall);
            if (data != null)
            {
                return mapper.Map<HallDTO>(data);
            }
            return null;
        }
    }
}