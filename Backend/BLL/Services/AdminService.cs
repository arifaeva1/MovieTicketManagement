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
    public class AdminService
    {
        public static AdminDTO Create(AdminDTO Admin)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Admin>(Admin);
            var data = DataAccessFactory.AdminData().Create(ht);

            if (data != null) return mapper.Map<AdminDTO>(data);
            return null;
        }


        public static bool Delete(string id)
        {

            var result = DataAccessFactory.AdminData().Delete(id);
            return result;

        }

        public static AdminDTO Get(string id)
        {
            var data = DataAccessFactory.AdminData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }
        public static AdminDTO Update(AdminDTO adminDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var admin = mapper.Map<Admin>(adminDTO);
            var data = DataAccessFactory.AdminData().Update(admin);
            if (data != null)
            {
                return mapper.Map<AdminDTO>(data);
            }
            return null;
        }
    }
}
