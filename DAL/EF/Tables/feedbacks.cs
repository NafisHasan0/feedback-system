using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class feedbacks
    {
        [Key]
        public int feedbackID { get; set; }

        [ForeignKey("users")]
        public int? userID { get; set; } // Nullable because feedback can be anonymous,so userID can be null
        public string title { get; set; }
        public string description { get; set; }
        public string Category { get; set; }
        public string IsAnonymous { get; set; }
        public DateTime DateSubmitted { get; set; }

        public virtual users users { get; set; }

        public virtual ICollection<feedbackResponses> feedbackResponses { get; set; }
        public feedbacks()
        {
            feedbackResponses = new List<feedbackResponses>();
        }

    }
}
