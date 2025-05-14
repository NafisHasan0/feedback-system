using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class feedbacksDTO
    {
        public int feedbackID { get; set; }
        public int userID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Category { get; set; }
        public string IsAnonymous { get; set; }
        public DateTime DateSubmitted { get; set; }

    }
}
