using AutoMapper;
using BAL.DTOs;
using DAL;
using DAL.EF.Tables;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace BAL.Services
{
    public class feedbacksService
    {
        

        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<feedbacks, feedbacksDTO>();
                cfg.CreateMap<feedbacksDTO, feedbacks>();
            });
            return new Mapper(config);

        }

        // Create feedback
        public string create(feedbacksDTO fb)
        {
            var repo = dataAccessFactory.feedbackCrud();
            var data = GetMapper().Map<feedbacks>(fb);
            return repo.create(data);
        }

        // Update feedback
        public string update(feedbacksDTO fb)
        {
            var repo = dataAccessFactory.feedbackCrud();
            var data = GetMapper().Map<feedbacks>(fb);
            return repo.update(data);
        }

        // Delete feedback
        public string delete(int id)
        {
            var repo = dataAccessFactory.feedbackCrud();
            return repo.delete(id);
        }

        // Get all feedbacks
        public List<feedbacksDTO> getAll()
        {
            var repo = dataAccessFactory.feedbackCrud();
            var data = repo.getAll();
            return GetMapper().Map<List<feedbacksDTO>>(data);
        }

        // Get feedback by feedbackID
        public feedbacksDTO get(int id)
        {
            var repo = dataAccessFactory.feedbackCrud();
            var data = repo.get(id);
            return GetMapper().Map<feedbacksDTO>(data);
        }





        //search feedback by category
        public List<feedbacksDTO> searchByCategory(string category)
        {
            var repo = dataAccessFactory.feedbackOtherFeature();
            var data = repo.searchByCategory(category);
            return GetMapper().Map<List<feedbacksDTO>>(data);
        }


        //search feedback by date
        public List<feedbacksDTO> searchByDate(DateTime date)
        {
            var repo = dataAccessFactory.feedbackOtherFeature();
            var data = repo.searchByDate(date);
            return GetMapper().Map<List<feedbacksDTO>>(data);
        }


        //search feedback by userID
        public List<feedbacksDTO> searchByUserID(int userID)
        {
            var repo = dataAccessFactory.feedbackOtherFeature();
            var data = repo.searchByUserID(userID);
            return GetMapper().Map<List<feedbacksDTO>>(data);
        }


        //filter feedback by anonymous
        public List<feedbacksDTO> searchByAnonymous()
        {
            var repo = dataAccessFactory.feedbackOtherFeature();
            var data = repo.searchByAnonymous();
            return GetMapper().Map<List<feedbacksDTO>>(data);
        }


    }
}
