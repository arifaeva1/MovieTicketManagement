using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketManagement.Controllers
{
    public class HallRepresenterController : ApiController
    {
        [HttpGet]
        [Route("api/staffs")]
        public HttpResponseMessage Users()
        {
            try
            {
                var data = HallRepresenterService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]

        [Route("api/staffs/{id}")]

        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, HallRepresenterService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/staffs/add")]
        [HttpPost]
        public HttpResponseMessage Add(HallRepresenterDTO staff)
        {
            try
            {
                var data = HallRepresenterService.Add(staff);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/staffs/update")]
        public HttpResponseMessage UpdateAdmin(HallRepresenterDTO staff)
        {
            try
            {
                var data = HallRepresenterService.Add(staff);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
