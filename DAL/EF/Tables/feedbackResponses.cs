using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class feedbackResponses
    {
        [Key]
        public int feedbackResponseID { get; set; }

        [ForeignKey("feedbacks")]
        public int feedbackID { get; set; }
 
        public string response { get; set; }

        public string IsResolved { get; set; }

        public DateTime DateSubmitted { get; set; }


        public virtual feedbacks feedbacks { get; set; }

    }
}
