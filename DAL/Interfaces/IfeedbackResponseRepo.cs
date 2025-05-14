using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IfeedbackResponseRepo
    {
        List<feedbackResponses> searchByFeedbackID(int id);

        List<feedbackResponses> searchNoResponse();

        List<feedbackResponses> searchNotResolved();
    }
}
