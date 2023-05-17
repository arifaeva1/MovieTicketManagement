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
    public class MovieRatingController : ApiController
    {
        [HttpGet]
        [Route("api/movieratings")]
        public HttpResponseMessage MovieRatings()
        {
            try
            {
                var data = MovieRatingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/movierating/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieRatingService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

       
        [Route("api/movierating/create")]
        [HttpPost]
        public HttpResponseMessage Create(MovieRatingDTO movierating)
        {

            try
            {
                var data = MovieRatingService.Create(movierating);


                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Rating Posted Successfully");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/movierating/update/{id}")]
        public HttpResponseMessage UpdateRating(MovieRatingDTO movierating)
        {

            try
            {
                var data = MovieRatingService.Update(movierating);
                return Request.CreateResponse(HttpStatusCode.OK, "Rating Updated");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }



        [Route("api/movierating/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteRating(string id)
        {
            var data = MovieRatingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
