using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class FeedbackRepository:IFeedbackRepository
    {
        DB context;
        public FeedbackRepository(DB context)
        {
            this.context = context;
        }


        public void AddFeedback(Feedback feedback)
        {
            var x = context.Feedback.Max(a => a.FeedbackId);
            feedback.FeedbackId = x + 1; 
            context.Feedback.Add(feedback);
            if (string.IsNullOrWhiteSpace(feedback.MailChatan)) feedback.MailChatan = "";
            context.SaveChanges();
        }

        public void DeleteFeedback(Feedback feedback)
        {
            context.Feedback.Remove(feedback);
            context.SaveChanges();
        }

        public void UpdateFeedback(Feedback feedback)
        {
            context.Feedback.Update(feedback);
            context.SaveChanges();
        }



        public List<Feedback> GetAllFeedback()
        {

            return context.Feedback.ToList();
        }
    }
}

