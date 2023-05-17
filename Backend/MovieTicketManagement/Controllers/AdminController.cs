using BLL.DTOs;
using BLL.Services;
using MovieTicketManagement.AdminAuth;
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
    [AdminLogged]
    public class AdminController : ApiController
    {
      
            [Route("api/admin/create")]
            [HttpPost]
            public HttpResponseMessage Create(AdminDTO admin)
            {
                try
                {
                    var data = AdminService.Create(admin);
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

            [Route("api/admin/delete/{id}")]
            [HttpGet]
            public HttpResponseMessage DeleteAdmin(string id)
            {
                var data = AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }


            [Route("api/admin/{id}")]
            [HttpGet]
            public HttpResponseMessage Get(string id)
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, AdminService.Get(id));
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            [HttpGet]
            [Route("api/admins")]
            public HttpResponseMessage Admins()
            {
                try
                {
                    var data = AdminService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            [HttpPost]
            [Route("api/admin/update/{id}")]
            public HttpResponseMessage UpdateAdmin(AdminDTO admin)
            {
                try
                {
                    var data = AdminService.Update(admin);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }


            [Route("api/admin/hallstaff/create")]
            [HttpPost]
            public HttpResponseMessage Create(HallStaffDTO hallstaff)
            {
                try
                {
                    var data = HallStaffService.Create(hallstaff);
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

            [Route("api/admin/hallstaff/delete/{id}")]
            [HttpGet]
            public HttpResponseMessage DeleteUser(string id)
            {
                var data = HallStaffService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            [Route("api/admin/hallstaff/{id}")]
            [HttpGet]
            public HttpResponseMessage Get1(string id)
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, HallStaffService.Get(id));
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }


            [HttpGet]
            [Route("api/admin/hallstaffs")]
            public HttpResponseMessage HallStaffs()
            {
                try
                {
                    var data = HallStaffService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            //

            [Route("api/admin/hall/create")]
            [HttpPost]
            public HttpResponseMessage Create(HallDTO hall)
            {
                try
                {
                    var data = HallService.Create(hall);
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

            [Route("api/admin/hall/{id}")]
            [HttpGet]
            public HttpResponseMessage Get2(string id)
            {
                try
                {
                    return Request.CreateResponse(HttpStatusCode.OK, HallService.Get(id));
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            [HttpGet]
            [Route("api/admin/halls")]
            public HttpResponseMessage Halls()
            {
                try
                {
                    var data = HallService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

            [Route("api/admin/hall/delete/{id}")]
            [HttpGet]
            public HttpResponseMessage DeleteHall(string id)
            {
                var data = HallService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }


            [HttpPost]
            [Route("api/admin/hall/update/{id}")]
            public HttpResponseMessage UpdateHall(HallDTO hall)
            {
                try
                {
                    var data = HallService.Update(hall);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
                }
            }


        }
    }