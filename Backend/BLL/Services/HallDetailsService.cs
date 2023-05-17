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
    public class HallDetailsService
    {
        public static List<HallDetailsDTO> Get()
        {
            var data = DataAccessFactory.HallDetailsDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallDetails, HallDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HallDetailsDTO>>(data);
            return mapped;
        }
        public static HallDetailsDTO Get(string Id)
        {
            var data = DataAccessFactory.HallDetailsDataAccess().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallDetails, HallDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HallDetailsDTO>(data);
            return mapped;
        }

        public static HallDetailsDTO Add(HallDetailsDTO hallStaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallDetailsDTO, HallDetails>();
                c.CreateMap<HallDetails, HallDetailsDTO>();

            });

            var mapper = new Mapper(cfg);
            var staff = mapper.Map<HallDetails>(hallStaff);
            var data = DataAccessFactory.HallDetailsDataAccess().Create(staff);

            if (data != null)
            {
                return mapper.Map<HallDetailsDTO>(data);
            }
            return null;
        }
        public static HallDetailsDTO Update(HallDetailsDTO hallstaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallDetailsDTO, HallDetails>();
                c.CreateMap<HallDetails, HallDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var staff = mapper.Map<HallDetails>(hallstaff);
            var data = DataAccessFactory.HallDetailsDataAccess().Update(staff);
            if (data != null)
            {
                return mapper.Map<HallDetailsDTO>(data);
            }
            return null;
        }

    }


}