using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class feedbacksResponsesRepo : Repo , IRepo<feedbackResponses, int, string>, IfeedbackResponseRepo
    {
        // Create feedback response
        public string create(feedbackResponses fb)
        {
            db.feedbackResponses.Add(fb);
            db.SaveChanges();
            return "Feedback response created successfully";
        }



        // Update feedback response
        public string update(feedbackResponses fb)
        {
            var data = db.feedbackResponses.Find(fb.feedbackResponseID);
            if (data != null)
            {
                data.response = fb.response;
                data.IsResolved = fb.IsResolved;
                data.DateSubmitted = fb.DateSubmitted;
                db.SaveChanges();
                return "Feedback response updated successfully";
            }
            else
            {
                return "Feedback response not found";
            }
        }



        // Delete feedback response
        public string delete(int id)
        {
            var data = db.feedbackResponses.Find(id);
            if (data != null)
            {
                db.feedbackResponses.Remove(data);
                db.SaveChanges();
                return "Feedback response deleted successfully";
            }
            else
            {
                return "Feedback response not found";
            }
        }

        // Get all feedback responses
        public List<feedbackResponses> getAll()
        {
            var data = db.feedbacks.ToList();

            foreach (var item in data)
            {
                var data2 = (from fb in db.feedbackResponses
                             where fb.feedbackID == item.feedbackID
                             select fb).ToList();

                if (data2.Count == 0)
                {
                    feedbackResponses fb = new feedbackResponses();

                    fb.feedbackID = item.feedbackID;
                    fb.response = null;
                    fb.IsResolved = null;
                    fb.DateSubmitted = DateTime.Now;

                    db.feedbackResponses.Add(fb);
                    db.SaveChanges();
                }

            }
            return db.feedbackResponses.ToList();
        }


        // Get feedback response by feedbackResponseID
        public feedbackResponses get(int id)
        {
            if (db.feedbackResponses.Find(id) == null)
            {
                return null;
            }
            else 
            {
                return db.feedbackResponses.Find(id);
            }
            
        }


        // Get feedback response by feedbackID
        public List<feedbackResponses> searchByFeedbackID(int id)
        {
            var data = (from fb in db.feedbackResponses
                        where fb.feedbackID == id
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


        //get feedback response , which didnt get response
        public List<feedbackResponses> searchNoResponse()
        {
            var data = (from fb in db.feedbackResponses
                        where fb.response == null
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


        //get feedback response , which are not resolved
        public List<feedbackResponses> searchNotResolved()
        {
            var data = (from fb in db.feedbackResponses
                        where fb.IsResolved == null
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
