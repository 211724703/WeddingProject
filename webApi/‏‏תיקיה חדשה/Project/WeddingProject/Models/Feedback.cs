using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string Discreptionfeedback { get; set; }
        public int Ratingfeedback { get; set; }
        public string MailChatan { get; set; }
        public string Workerid { get; set; }
        public string UserId { get; set; }

        public Customers User { get; set; }
        public Workers Worker { get; set; }
    }
}
