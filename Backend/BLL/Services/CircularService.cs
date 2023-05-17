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
    public class CircularService
    {
        public static CircularDTO Create(CircularDTO circular)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CircularDTO, Circular>();
                cfg.CreateMap<Circular, CircularDTO>();
            });
            var mapper = new Mapper(config);
            var ht = mapper.Map<Circular>(circular);
            var data = DataAccessFactory.CircularData().Create(ht);
            if (data != null)
            {
                return mapper.Map<CircularDTO>(data);
            }
            return null;
        }

        public static List<CircularDTO> Get()
        {
            var data = DataAccessFactory.CircularData().Read();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Circular, CircularDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CircularDTO>>(data);
        }

        public static CircularDTO Get(string id)
        {
            var data = DataAccessFactory.CircularData().Read(id);
            var config = MapService.OneTimeMapping<Circular, CircularDTO>();
            var mapper = new Mapper(config);
            return mapper.Map<CircularDTO>(data);
        }

        public static bool Delete(string id)
        {
            var data = DataAccessFactory.CircularData().Delete(id);
            return data;

        }

        public static CircularDTO Update(CircularDTO circularDTO)
        {
            var config = MapService.Mapping<Circular, CircularDTO>();
            var mapper = new Mapper(config);
            var notice = mapper.Map<Circular>(circularDTO);
            var data = DataAccessFactory.CircularData().Update(notice);
            if (data != null)
            {
                return mapper.Map<CircularDTO>(data);
            }
            return null;
        }
    }
}