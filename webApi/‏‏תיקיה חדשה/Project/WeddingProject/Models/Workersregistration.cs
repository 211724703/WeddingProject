using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Workersregistration
    {
        public int WorkersregistrationId { get; set; }
        public DateTime Dateworkersregistration { get; set; }
        public string Discreptionworkersregistration { get; set; }
        public string Mailworker { get; set; }
        public int Statusid { get; set; }

        public Status Status { get; set; }
    }
}
