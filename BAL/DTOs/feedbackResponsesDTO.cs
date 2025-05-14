using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class feedbackResponsesDTO
    {
        public int feedbackResponseID { get; set; }
        public int feedbackID { get; set; }

        public string response { get; set; }

        public string IsResolved { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
