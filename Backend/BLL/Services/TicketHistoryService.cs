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
    public class TicketHistoryService
    {
        public static List<TicketHistoryDTO> Get()
        {
            var data = DataAccessFactory.TicketHistoryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TicketHistory, TicketHistoryDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TicketHistoryDTO>>(data);
            return mapped;
        }
        public static TicketHistoryDTO Get(string id)
        {
            var data = DataAccessFactory.TicketHistoryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<TicketHistory, TicketHistoryDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TicketHistoryDTO>(data);
            return mapped;
        }



        public static TicketHistoryDTO Create(TicketHistoryDTO tickethistory)
        {
          

            tickethistory.HistoryId = tickethistory.TicketId;

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TicketHistoryDTO, TicketHistory>();
                c.CreateMap<TicketHistory, TicketHistoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var ht = mapper.Map<TicketHistory>(tickethistory);
            var data = DataAccessFactory.TicketHistoryData().Create(ht);


            if (data != null)
                return mapper.Map<TicketHistoryDTO>(data);
            return null;
        }


        public static TicketHistoryDTO Update(TicketHistoryDTO tickethistoryDTO)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<TicketHistoryDTO, TicketHistory>();
                c.CreateMap<TicketHistory, TicketHistoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var tickethistory = mapper.Map<TicketHistory>(tickethistoryDTO);
            var data = DataAccessFactory.TicketHistoryData().Update(tickethistory);
            if (data != null)
            {
                return mapper.Map<TicketHistoryDTO>(data);
            }
            return null;
        }



        public static bool Delete(string id)
        {

            var result = DataAccessFactory.TicketHistoryData().Delete(id);
            return result;

        }


       
    }
}
