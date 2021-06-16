using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Status
    {
        public Status()
        {
            Workersregistration = new HashSet<Workersregistration>();
            Workertowedding = new HashSet<Workertowedding>();
        }

        public int Statusid { get; set; }
        public string Statusname { get; set; }

        public ICollection<Workersregistration> Workersregistration { get; set; }
        public ICollection<Workertowedding> Workertowedding { get; set; }
    }
}
