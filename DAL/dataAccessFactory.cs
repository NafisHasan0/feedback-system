using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dataAccessFactory
    {
        //users crud 
        public static IRepo<users, int, string> UserCrud()
        {
            return new usersRepo();
        }




        //feedbacks crud
        public static IRepo<feedbacks, int, string> feedbackCrud()
        {
            return new feedbacksRepo();
        }

        //feedbacks other features
        public static IfeedbackRepo feedbackOtherFeature()
        {
            return new feedbacksRepo();
        }





        // feedback response crud
        public static IRepo<feedbackResponses, int, string> feedbackResponsesCrud()
        {
            return new feedbacksResponsesRepo();
        }
        //feedback response other features
        public static IfeedbackResponseRepo feedbackResponseOtherFeature()
        {
            return new feedbacksResponsesRepo();
        }


    }
}
