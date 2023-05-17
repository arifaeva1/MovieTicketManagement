using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketManagement.Controllers
{
    public class ActiveUserController : ApiController
    {
        [HttpGet]
        [Route("api/blockusers")]

        public HttpResponseMessage ActiveGet()
        {
            try
            {
                var data = ActiveUserService.ActiveGet().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/activeuser")]

        public HttpResponseMessage BlockGet()
        {
            try
            {
                var data = ActiveUserService.BlockGet().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [Route("api/user/active/{id}")]
        [HttpPost]

        public HttpResponseMessage Update(string id)
        {
            if (ActiveUserService.Block(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Activation Successfully done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}