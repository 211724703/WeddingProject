using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Typeofworker
    {
        public Typeofworker()
        {
            Sadottypeofworker = new HashSet<Sadottypeofworker>();
            Typetouser = new HashSet<Typetouser>();
            Workers = new HashSet<Workers>();
        }

        public int Typeid { get; set; }
        public string Nametype { get; set; }
        public int Precent { get; set; }
        public string Misusetotipe { get; set; }

        public ICollection<Sadottypeofworker> Sadottypeofworker { get; set; }
        public ICollection<Typetouser> Typetouser { get; set; }
        public ICollection<Workers> Workers { get; set; }
    }
}
