using Common;
using System;
using System.Collections.Generic;



namespace Common
{
    public partial class CFeedback
    {
        public int FeedbackId { get; set; }
        public string Discreptionfeedback { get; set; }
        public int Ratingfeedback { get; set; }
        public string MailChatan { get; set; }
        public int Workerid { get; set; }
        public string UserId { get; set; }

        //public CCustomers User { get; set; }
        //public Workers Worker { get; set; }
    }
}
