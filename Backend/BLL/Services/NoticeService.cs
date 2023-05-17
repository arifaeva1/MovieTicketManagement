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
    public class NoticeService
    {
        public static NoticeDTO Create(NoticeDTO Notice)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<NoticeDTO, Notice>();
                c.CreateMap<Notice, NoticeDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<Notice>(Notice);
            var data = DataAccessFactory.NoticeDataAccess().Create(ht);

            if (data != null) return mapper.Map<NoticeDTO>(data);
            return null;
        }


        public static List<NoticeDTO> Get()
        {
            var data = DataAccessFactory.NoticeDataAccess().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<NoticeDTO>>(data);
            return mapped;
        }

        public static NoticeDTO Get(int id)
        {
            var data = DataAccessFactory.NoticeDataAccess().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<NoticeDTO>(data);
            return mapped;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.NoticeDataAccess().Delete(id);
            return data;

        }

        public static NoticeDTO Update(NoticeDTO noticeDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<NoticeDTO, Notice>();
                c.CreateMap<Notice, NoticeDTO>();
            });
            var mapper = new Mapper(cfg);
            var notice = mapper.Map<Notice>(noticeDTO);
            var data = DataAccessFactory.NoticeDataAccess().Update(notice);
            if (data != null)
            {
                return mapper.Map<NoticeDTO>(data);
            }
            return null;
        }
    }
}