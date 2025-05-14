using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IfeedbackRepo
    {
        List<feedbacks> searchByCategory(string category);

        List<feedbacks> searchByDate(DateTime date);

        List<feedbacks> searchByUserID(int userID);

        List<feedbacks> searchByAnonymous();



    }
}
