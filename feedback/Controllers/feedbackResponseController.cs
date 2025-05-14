using BAL.DTOs;
using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace feedback.Controllers
{
    public class feedbackResponseController : ApiController
    {
        public feedbackResponseService service = new feedbackResponseService();


        [HttpPost]
        [Route("api/response/create")]

        public HttpResponseMessage create(feedbackResponsesDTO fb)
        {
            fb.DateSubmitted = DateTime.Now;
            var data = service.create(fb);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpPut]
        [Route("api/response/update/{id}")]
        public HttpResponseMessage update(feedbackResponsesDTO fb, int id)
        {
            fb.feedbackResponseID = id;
            fb.DateSubmitted = DateTime.Now;
            var data = service.update(fb);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpDelete]
        [Route("api/response/delete/{id}")]
        public HttpResponseMessage delete(int id)
        {
            var data = service.delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/response/getall")]
        public HttpResponseMessage getAll()
        {
            var data = service.getAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/response/get/{id}")]
        public HttpResponseMessage get(int id)
        {
            var data = service.get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/response/feedbackid/{id}")]
        public HttpResponseMessage getByFeedbackID(int id)
        {
            var data = service.getByFeedbackID(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/response/noresponse")]
        public HttpResponseMessage getNoResponse()
        {
            var data = service.getNoResponse();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [HttpGet]
        [Route("api/response/notresolved")]
        public HttpResponseMessage getNotResolved()
        {
            var data = service.getNotResolved();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



    }
}
