using Common;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class FeedbackServise : IFeedbackServise
    {
        IFeedbackRepository ifeedr;

        public FeedbackServise(IFeedbackRepository ifeedr)
        {
            this.ifeedr = ifeedr;
        }

        public void AddFeedback(CFeedback feed)
        {
            Feedback feedback = new Feedback()
            {
                FeedbackId = feed.FeedbackId,
                Discreptionfeedback = feed.Discreptionfeedback,
                Ratingfeedback = feed.Ratingfeedback,
                MailChatan = feed.MailChatan,//
                Workerid = feed.Workerid,//
                UserId = feed.UserId,
            };
            ifeedr.AddFeedback(feedback);

        }

        public void DeleteFeedback(CFeedback feed)
        {
            Feedback Cfeedback = new Feedback()
            {
                FeedbackId = feed.FeedbackId,
                Discreptionfeedback = feed.Discreptionfeedback,
                Ratingfeedback = feed.Ratingfeedback,
                MailChatan = feed.MailChatan,
                Workerid = feed.Workerid,
                UserId = feed.UserId,
            };
            Feedback feedback = new Feedback()
            {
                FeedbackId = feed.FeedbackId,
                Discreptionfeedback = feed.Discreptionfeedback,
                Ratingfeedback = feed.Ratingfeedback,
                MailChatan = feed.MailChatan,
                Workerid = feed.Workerid,
                UserId = feed.UserId,
            };
            ifeedr.DeleteFeedback(feedback);
        }

        public void UpdateFeedback(CFeedback feedback)
        {
            CFeedback cfeedback = new CFeedback()
            {
                FeedbackId = feedback.FeedbackId,
                Discreptionfeedback = feedback.Discreptionfeedback,
                Ratingfeedback = feedback.Ratingfeedback,
                MailChatan = feedback.MailChatan,
                Workerid = feedback.Workerid,
                UserId = feedback.UserId,
            };
            Feedback feedbackk = new Feedback()
            {
                FeedbackId = feedback.FeedbackId,
                Discreptionfeedback = feedback.Discreptionfeedback,
                Ratingfeedback = feedback.Ratingfeedback,
                MailChatan = feedback.MailChatan,
                Workerid = feedback.Workerid,
                UserId = feedback.UserId,
            };
            ifeedr.UpdateFeedback(feedbackk);
        }



        public List<CFeedback> GetAllFeedback()
        {

            List<CFeedback> feedbacks = (from tmp in ifeedr.GetAllFeedback() 
                                        select new CFeedback
                                        {
                                            FeedbackId = tmp.FeedbackId,
                                            Discreptionfeedback = tmp.Discreptionfeedback,
                                            Ratingfeedback = tmp.Ratingfeedback,
                                            MailChatan = tmp.MailChatan,
                                            Workerid = tmp.Workerid,
                                            UserId = tmp.UserId,

                                        }).ToList();

            return feedbacks;
        }

    }
}
    


