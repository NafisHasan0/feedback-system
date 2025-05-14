using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class feedbackContext : DbContext
    {
        public DbSet<users> users { get; set; }
        public DbSet<feedbacks> feedbacks { get; set; }
        public DbSet<feedbackResponses> feedbackResponses { get; set; }
        

    }
}
