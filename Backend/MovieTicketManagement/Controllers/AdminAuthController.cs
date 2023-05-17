using BLL.Services;
using MovieTicketManagement.AdminAuth;
using MovieTicketManagement.Models;
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

    public class AdminAuthController : ApiController
    {

        [HttpPost]
        [Route("api/adminlogin")]
        public HttpResponseMessage Login(AdminLoginModel login)
        {
            try
            {
                var res = AdminAuthService.Authenticate(login.Aname, login.Password);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "Admin not found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [AdminLogged]
        [HttpGet]
        [Route("api/admin/logout")]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            try
            {
                var res = AdminAuthService.Logout(token);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }

        }



    }
}