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
    public class HallRepresenterService
    {
        public static List<HallRepresenterDTO> Get()
        {
            var data = DataAccessFactory.HallRepresenterDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallRepresenter, HallRepresenterDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HallRepresenterDTO>>(data);
            return mapped;
        }
        public static HallRepresenterDTO Get(int Id)
        {
            var data = DataAccessFactory.HallRepresenterDataAccess().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallRepresenter, HallRepresenterDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HallRepresenterDTO>(data);
            return mapped;
        }
        public static HallRepresenterDTO Add(HallRepresenterDTO hallStaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallRepresenterDTO, HallRepresenter>();
                c.CreateMap<HallRepresenter, HallRepresenterDTO>();

            });

            var mapper = new Mapper(cfg);
            var staff = mapper.Map<HallRepresenter>(hallStaff);
            var data = DataAccessFactory.HallRepresenterDataAccess().Create(staff);

            if (data != null)
            {
                return mapper.Map<HallRepresenterDTO>(data);
            }
            return null;
        }

        public static HallRepresenterDTO Update(HallRepresenterDTO hallstaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<HallRepresenterDTO, HallRepresenter>();
                c.CreateMap<HallRepresenter, HallRepresenterDTO>();
            });
            var mapper = new Mapper(cfg);
            var staff = mapper.Map<HallRepresenter>(hallstaff);
            var data = DataAccessFactory.HallRepresenterDataAccess().Update(staff);
            if (data != null)
            {
                return mapper.Map<HallRepresenterDTO>(data);
            }
            return null;
        }
    }
}