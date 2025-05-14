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
    public class usersService
    {
       

        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<users,usersDTO>();
                cfg.CreateMap<usersDTO, users>();
            });
            return new Mapper(config);

        }

        // Create user
        public string create(usersDTO user)
        {
            var repo = dataAccessFactory.UserCrud();
            var data = GetMapper().Map<users>(user);
            return repo.create(data);
        }

        // Update user
        public string update(usersDTO user)
        {
            var repo = dataAccessFactory.UserCrud();
            var data = GetMapper().Map<users>(user);
            return repo.update(data);
        }

        
        public string delete(int id)
        {
            var repo = dataAccessFactory.UserCrud();
            return repo.delete(id);
        }

        //
        public List<usersDTO> getAll()
        {
            var repo = dataAccessFactory.UserCrud();
            var data = repo.getAll();
            return GetMapper().Map<List<usersDTO>>(data);
        }

        // Get user by ID
        public usersDTO get(int id)
        {
            var repo = dataAccessFactory.UserCrud();
            var data = repo.get(id);
            return GetMapper().Map<usersDTO>(data);
        }


    }
}
