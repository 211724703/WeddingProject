using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Workertowedding
    {
        public int Workertoweddingid { get; set; }
        public int Workerid { get; set; }
        public string Userid { get; set; }
        public int Statusid { get; set; }

        public Status Status { get; set; }
        public Customers User { get; set; }
        public Workers Worker { get; set; }
    }
}
