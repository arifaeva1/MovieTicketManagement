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
   public class HallStaffService
    {

        public static HallStaffDTO Create(HallStaffDTO hallStaff)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<HallStaffDTO, HallStaff>();
                c.CreateMap<HallStaff, HallStaffDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<HallStaff>(hallStaff);
            var data = DataAccessFactory.HallStaffData().Create(ht);

            if (data != null) return mapper.Map<HallStaffDTO>(data);
            return null;
        }

        public static bool Delete(string id)
        {

            var result = DataAccessFactory.HallStaffData().Delete(id);
            return result;

        }

        public static HallStaffDTO Get(string id)
        {
            var data = DataAccessFactory.HallStaffData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallStaff, HallStaffDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HallStaffDTO>(data);
            return mapped;
        }

        public static List<HallStaffDTO> Get()
        {
            var data = DataAccessFactory.HallStaffData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallStaff, HallStaffDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HallStaffDTO>>(data);
            return mapped;
        }

    }
}
