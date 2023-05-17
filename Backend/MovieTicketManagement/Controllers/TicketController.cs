using BLL.DTOs;
using BLL.Services;
using MovieTicketManagement.UserAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MovieTicketManagement.Controllers
{
    [EnableCors("*", "*", "*")]
   // [UserLogged]
    public class TicketController : ApiController
    {
        [Route("api/ticket/create")]
        [HttpPost]
        public HttpResponseMessage Create(TicketDTO ticket)
        {
            try
            {
                var data = TicketService.Create(ticket);
                if (data != null)
                { 
                    TicketHistoryDTO THd = new TicketHistoryDTO();
                    THd.UserId = ticket.UserId;
                    THd.HistoryStatus = 1;
                    THd.TicketId=data.TicketId;
                    THd.TotalAmount = ticket.TicketPrice;

                    TicketHistoryService.Create(THd);

                    return Request.CreateResponse(HttpStatusCode.OK, "Your ticket is confirmed");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/tickets")]
        public HttpResponseMessage Tickets()
        {
            try
            {
                var data = TicketService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/ticket/{id}")]
        [HttpGet]
        public HttpResponseMessage Read(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, TicketService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/ticket/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteTicket(string id)
        {
            var data = TicketService.Delete(id);
            if (data)
            {
                var thd = TicketHistoryService.Get(id);
                thd.HistoryStatus = 0;
                var res = TicketHistoryService.Update(thd);
            }
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


    }
}
