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
    public class HallDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/zones")]
        public HttpResponseMessage Zones()
        {
            try
            {
                var data = HallDetailsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/zones/add")]
        [HttpPost]
        public HttpResponseMessage Add(HallDetailsDTO zone)
        {
            try
            {
                var data = HallDetailsService.Add(zone);
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
        [Route("api/zone/update")]
        public HttpResponseMessage Update(HallDetailsDTO zone)
        {
            try
            {
                var data = HallDetailsService.Add(zone);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /*[HttpDelete]
        [Route("api/zone/delete/{code}")]
        public HttpResponseMessage Delete(string code)
        {
            try
            {
                var data = HallDetailsService.Delete(code);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }*/

    }
}

