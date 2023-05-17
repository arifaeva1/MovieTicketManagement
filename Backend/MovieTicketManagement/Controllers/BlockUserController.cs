using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketManagement.Controllers
{
    public class BlockUserController : ApiController
    {
        [HttpGet]
        [Route("api/activeusers")]

        public HttpResponseMessage ActiveGet()
        {
            try
            {
                var data = BlockUserService.ActiveGet().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpGet]
        [Route("api/blockusers")]

        public HttpResponseMessage BlockGet()
        {
            try
            {
                var data = BlockUserService.BlockGet().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [Route("api/user/block/{id}")]
        [HttpPost]

        public HttpResponseMessage Update(string id)
        {
            if (BlockUserService.Block(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Block Successfully done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Something went wrong");
        }
    }
}
