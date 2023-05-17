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
    public class CircularController : ApiController
    {
        [HttpPost]
        [Route("api/circular/create")]
        public HttpResponseMessage Create(CircularDTO circular)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = CircularService.Create(circular);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/circular/list")]
        public HttpResponseMessage GetAllCircular()
        {
            try
            {
                var data = CircularService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/circular/{id}")]
        public HttpResponseMessage GetSinglecircular(string id)
        {
            try
            {
                var data = CircularService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpDelete]
        [Route("api/circular/delete/{id}")]
        public HttpResponseMessage DeleteCirculare(string id)
        {
            try
            {
                var data = CircularService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/circular/update")]
        public HttpResponseMessage UpdateNotice(CircularDTO circular)
        {
            try
            {
                var data = CircularService.Update(circular);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }




    }
}
