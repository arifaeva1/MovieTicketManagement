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
    public class ShowTodayController : ApiController
    {
        

           [HttpGet]
           [Route("api/shows")]
           public HttpResponseMessage AllShows()
           {
               try
               {
                   var mov = ShowTodayService.Get();
                   return Request.CreateResponse(HttpStatusCode.OK,mov );
               }
               catch (Exception ex)
               {
                   return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
               }
           }
           

        [HttpGet]

        [Route("api/shows/{id}")]

        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, ShowTodayService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/shows/add")]
        [HttpPost]
        public HttpResponseMessage Add(ShowTodayDTO movie)
        {
            try
            {
                var data = ShowTodayService.Add(movie);
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

        //[HttpDelete]
        //[Route("api/shows/delete/{id}")]
        //public HttpResponseMessage Delete(int id)
        //{
        //    try
        //    {
        //        var data = ShowTodayService.Delete(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        [HttpPost]
        [Route("api/shows/update")]
        public HttpResponseMessage Update(ShowTodayDTO movie)
        {
            try
            {
                var data = ShowTodayService.Add(movie);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
