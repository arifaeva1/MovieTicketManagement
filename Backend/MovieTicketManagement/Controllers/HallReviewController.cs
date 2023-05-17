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
    public class HallReviewController : ApiController
    {
        [Route("api/hallreview/create")]
        [HttpPost]
        public HttpResponseMessage Create(HallReviewDTO hallreview)
        {

            try
            {
                var data = HallReviewService.Create(hallreview);


                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, " Review Posted Successfully");
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/hallreviews")]
        public HttpResponseMessage HallReviews ()
        {
            try
            {
                var data = HallReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/hallreview/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, HallReviewService.Get(id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/hallreview/update/{id}")]
        public HttpResponseMessage UpdateUser(HallReviewDTO hallreview)
        {

            try
            {
                var data = HallReviewService.Update(hallreview);
                return Request.CreateResponse(HttpStatusCode.OK, "Review Updated");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [Route("api/hallreview/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteReview(string id)
        {
            
            var data = HallReviewService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

    }
}
