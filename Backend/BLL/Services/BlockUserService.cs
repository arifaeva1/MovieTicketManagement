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
    public class BlockUserService
    {
        public static List<UserDTO> ActiveGet()
        {
            //return new List<PatientDTO>();
            var data = DataAccessFactory.BlockUsertData().ActiveGet();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<UserDTO>>(data);
            return converted;
        }
        public static List<UserDTO> BlockGet()
        {
            //return new List<PatientDTO>();
            var data = DataAccessFactory.BlockUsertData().BlockGet();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<UserDTO>>(data);
            return converted;
        }
        public static bool Block(string item)
        {
            return DataAccessFactory.BlockUsertData().Block(item);
        }
    }
}