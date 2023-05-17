using BLL.Services;
using MovieTicketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieTicketManagement.Controllers
{
    public class EmailController : ApiController
    {
        private readonly EmailService emailService;



        public EmailController()
        {
            emailService = new EmailService();
        }

        [Route("api/email")]

        [HttpPost]
        public IHttpActionResult SendEmail(EmailRequestModel request)
        {
            bool result = emailService.SendEmail(request.Recipient, request.Subject, request.Body);



            if (result)
            {
                return Ok("Allah bacaiche");
            }
            else
            {
                return BadRequest("kam hoy nai vai");
            }
        }
    }



   
}
    

