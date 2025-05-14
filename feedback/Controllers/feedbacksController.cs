using BAL.DTOs;
using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;


namespace feedback.Controllers
{
    public class feedbacksController : ApiController
    {
        public feedbacksService service = new feedbacksService();



        [HttpPost]
        [Route("api/feedbacks/create")]

        public HttpResponseMessage create(feedbacksDTO fb)
        {
            fb.DateSubmitted = DateTime.Now;
            var data = service.create(fb);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }




        [HttpPut]
        [Route("api/feedbacks/update/{id}")]
        public HttpResponseMessage update(feedbacksDTO fb, int id)
        {
            fb.feedbackID = id;
            var data = service.update(fb);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        [HttpDelete]
        [Route("api/feedbacks/delete/{id}")]
        public HttpResponseMessage delete(int id)
        {
            var data = service.delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/feedbacks/getall")]
        public HttpResponseMessage getAll()
        {
            var data = service.getAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/feedbacks/get/{id}")]
        public HttpResponseMessage get(int id)
        {
            var data = service.get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }




        [HttpGet]
        [Route("api/feedbacks/category/{category}")]
        public HttpResponseMessage searchByCategory(string category)
        {
            var data = service.searchByCategory(category);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/feedbacks/date/{date}")]
        public HttpResponseMessage searchByDate(DateTime date)
        {
            var data = service.searchByDate(date);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/feedbacks/user/{userID}")]
        public HttpResponseMessage searchByUserID(int userID)
        {
            var data = service.searchByUserID(userID);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/feedbacks/anonymous")]
        public HttpResponseMessage searchByAnonymous()
        {
            var data = service.searchByAnonymous();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
