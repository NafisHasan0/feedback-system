using AutoMapper;
using BAL.DTOs;
using DAL;
using DAL.EF.Tables;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class feedbackResponseService
    {
        

        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<feedbackResponses, feedbackResponsesDTO>();
                cfg.CreateMap<feedbackResponsesDTO, feedbackResponses>();
            });
            return new Mapper(config);

        }

        //create feedback response
        public string create(feedbackResponsesDTO fb)
        {
            var repo = dataAccessFactory.feedbackResponsesCrud();
            var data = GetMapper().Map<feedbackResponses>(fb);
            return repo.create(data);
        }


        //update feedback response
        public string update(feedbackResponsesDTO fb)
        {
            var repo = dataAccessFactory.feedbackResponsesCrud();
            var data = GetMapper().Map<feedbackResponses>(fb);
            return repo.update(data);
        }


        //delete feedback response
        public string delete(int id)
        {
            var repo = dataAccessFactory.feedbackResponsesCrud();
            return repo.delete(id);
        }


        //get all feedback responses
        public List<feedbackResponsesDTO> getAll()
        {
            var repo = dataAccessFactory.feedbackResponsesCrud();
            var data = repo.getAll();
            return GetMapper().Map<List<feedbackResponsesDTO>>(data);
        }


        // Get feedback response by feedbackResponseID
        public feedbackResponsesDTO get(int id)
        {
            var repo = dataAccessFactory.feedbackResponsesCrud();
            var data = repo.get(id);
            return GetMapper().Map<feedbackResponsesDTO>(data);
        }





        // Get feedback response by feedbackID
        public List<feedbackResponsesDTO> getByFeedbackID(int id)
        {
            var repo = dataAccessFactory.feedbackResponseOtherFeature();
            var data = repo.searchByFeedbackID(id);
            return GetMapper().Map<List<feedbackResponsesDTO>>(data);
        }



        //get feedback response , which didnt get response
        public List<feedbackResponsesDTO> getNoResponse()
        {
            var repo = dataAccessFactory.feedbackResponseOtherFeature();
            var data = repo.searchNoResponse();
            return GetMapper().Map<List<feedbackResponsesDTO>>(data);
        }


        //get feedback response , which are not resolved
        public List<feedbackResponsesDTO> getNotResolved()
        {
            var repo = dataAccessFactory.feedbackResponseOtherFeature();
            var data = repo.searchNotResolved();
            return GetMapper().Map<List<feedbackResponsesDTO>>(data);
        }








    }
}
