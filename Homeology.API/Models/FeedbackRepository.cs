using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Homeology.API.Models
{
    public class FeedbackRepository
    {
        private static HomeologyEntities homeologyContext = new HomeologyEntities();
        public static List<Feedback> GetAllFeedback()
        {
            var query = from feedback in homeologyContext.Feedbacks
                        select feedback;
            return query.ToList();
        }

        public static List<Feedback> SearchAgentsByMessage(string feedbackMessage)
        {
            var query = from feedback in homeologyContext.Feedbacks
                        where feedback.message.Contains(feedbackMessage)
                        select feedback;
            return query.ToList();
        }

        public static Feedback GetFeedback(int feedbackId)
        {
            var query = from feedback in homeologyContext.Feedbacks
                        where feedback.user_id == feedbackId
                        select feedback;
            return query.SingleOrDefault();
        }

        public static List<Feedback> InsertFeedback(Feedback e)
        {
            homeologyContext.Feedbacks.Add(e);
            homeologyContext.SaveChanges();
            return GetAllFeedback();
        }

        public static List<Feedback> UpdateAgent(Feedback e)
        {
            var data = (from feedback in homeologyContext.Feedbacks
                       where feedback.feedback_id == e.feedback_id
                       select feedback).SingleOrDefault();
            data.user_id = e.user_id;
            data.UserProfile = e.UserProfile;
            data.message = e.message;
            data.date_added = e.date_added;
            homeologyContext.SaveChanges();
            return GetAllFeedback();
        }

        public static List<Feedback> DeleteFeedback(Feedback e)
        {
            var data = (from feedback in homeologyContext.Feedbacks
                       where feedback.feedback_id == e.feedback_id
                       select feedback).SingleOrDefault();
            homeologyContext.Feedbacks.Remove(data);
            homeologyContext.SaveChanges();
            return GetAllFeedback();
        }

    }
}