using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class feedbacksRepo : Repo, IRepo<feedbacks, int, string>, IfeedbackRepo
    {
        // Create feedback
        public string create(feedbacks fb)
        {
            if (fb.IsAnonymous == "yes")
            {
                fb.userID = null;
            }
            
            if (db.users.Find(fb.userID) == null)
            {
                return "There is no user in this userID";
            }

            db.feedbacks.Add(fb);
            db.SaveChanges();
            return "Feedback created successfully";
        }

        // Update feedback
        public string update(feedbacks fb)
        {
            var data = db.feedbacks.Find(fb.feedbackID);
            if (data != null)
            {
                data.title = fb.title;
                data.description = fb.description;
                data.Category = fb.Category;
                db.SaveChanges();
                return "Feedback updated successfully";
            }
            else
            {
                return "Feedback not found";
            }
        }

        // Delete feedback
        public string delete(int id)
        {
            var data = db.feedbacks.Find(id);
            if (data != null)
            {
                db.feedbacks.Remove(data);
                db.SaveChanges();
                return "Feedback deleted successfully";
            }
            else
            {
                return "Feedback not found";
            }
        }

        // Get all feedbacks
        public List<feedbacks> getAll()
        {
            return db.feedbacks.ToList();
        }


        // Get feedback by feedbackID
        public feedbacks get(int id)
        {
            if (db.feedbacks.Find(id) == null)
            {
                return null;
            }
            else
            {
                return db.feedbacks.Find(id);
            }
            
        }

        //search feedback by category
        public List<feedbacks> searchByCategory(string category)
        {
            var data = (from fb in db.feedbacks
                        where fb.Category.Contains(category)
                        select fb).ToList();
            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                return data;
            }
            
        }

        //search feedback by date
        public List<feedbacks> searchByDate(DateTime date)
        {
            var data = (from fb in db.feedbacks
                        where fb.DateSubmitted == date
                        select fb).ToList();
            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                return data;
            }
           
        }

        //search feedback by userID
        public List<feedbacks> searchByUserID(int userID)
        {
            var data = (from fb in db.feedbacks
                        where fb.userID == userID
                        select fb).ToList();
            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                return data;
            }
                
        }

        //filter feedback by anonymous
        public List<feedbacks> searchByAnonymous()
        {
            var data = (from fb in db.feedbacks
                        where fb.IsAnonymous == "yes"
                        select fb).ToList();

            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                return data;
            }

            
        }





    }
}
