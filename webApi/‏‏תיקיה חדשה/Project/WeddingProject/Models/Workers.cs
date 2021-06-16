using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Workers
    {
        public Workers()
        {
            Feedback = new HashSet<Feedback>();
            Valuestosadeofworker = new HashSet<Valuestosadeofworker>();
            Workertowedding = new HashSet<Workertowedding>();
        }

        public string Workerid { get; set; }
        public string Nameworker { get; set; }
        public int Selfphone { get; set; }
        public string Description { get; set; }
        public string Mailworker { get; set; }
        public int Typeid { get; set; }

        public Typeofworker Type { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
        public ICollection<Valuestosadeofworker> Valuestosadeofworker { get; set; }
        public ICollection<Workertowedding> Workertowedding { get; set; }
    }
}
