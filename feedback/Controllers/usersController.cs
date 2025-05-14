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
    public class usersController : ApiController
    {
        public usersService service = new usersService();



        [HttpPost]
        [Route("api/users/create")]

        public HttpResponseMessage create(usersDTO user)
        {
            user.role = "user";
            var data = service.create(user);
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }




        [HttpPut]
        [Route("api/users/update/{id}")]
        public HttpResponseMessage update(usersDTO user,int id)
        {
            user.userID = id;
            var data = service.update(user);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        [HttpDelete]
        [Route("api/users/delete/{id}")]
        public HttpResponseMessage delete(int id)
        {
            var data = service.delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        [HttpGet]
        [Route("api/users/getall")]
        public HttpResponseMessage getAll() 
        {
            var data = service.getAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        [HttpGet]
        [Route("api/users/get/{id}")]
        public HttpResponseMessage get(int id)
        {
            var data = service.get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
