using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class users
    {
        [Key]
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public virtual ICollection<feedbacks> feedbacks { get; set; }
        public users()
        {
            feedbacks = new List<feedbacks>();
           
        }

    }
}
