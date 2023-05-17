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
    public class ShowTodayService
    {

        public static List<ShowTodayDTO> Get()
        {
            var data = DataAccessFactory.ShowTodaysDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ShowToday, ShowTodayDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ShowTodayDTO>>(data);
            return mapped;
        }

        public static ShowTodayDTO Get(int Id)
        {
            var data = DataAccessFactory.ShowTodaysDataAccess().Read(Id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ShowToday, ShowTodayDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ShowTodayDTO>(data);
            return mapped;
        }

        public static ShowTodayDTO Add(ShowTodayDTO hallStaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ShowTodayDTO, ShowToday>();
                c.CreateMap<ShowToday, ShowTodayDTO>();

            });

            var mapper = new Mapper(cfg);
            var staff = mapper.Map<ShowToday>(hallStaff);
            var data = DataAccessFactory.ShowTodaysDataAccess().Create(staff);

            if (data != null)
            {
                return mapper.Map<ShowTodayDTO>(data);
            }
            return null;
        }

        public static ShowTodayDTO Update(ShowTodayDTO hallstaff)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ShowTodayDTO, ShowToday>();
                c.CreateMap<ShowToday, ShowTodayDTO>();
            });
            var mapper = new Mapper(cfg);
            var staff = mapper.Map<ShowToday>(hallstaff);
            var data = DataAccessFactory.ShowTodaysDataAccess().Update(staff);
            if (data != null)
            {
                return mapper.Map<ShowTodayDTO>(data);
            }
            return null;
        }
    }
}
