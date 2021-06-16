using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Typetouser
    {
        public int Typetouserid { get; set; }
        public int Typeid { get; set; }
        public string Userid { get; set; }
        public int Precent { get; set; }

        public Typeofworker Type { get; set; }
        public Customers User { get; set; }
    }
}
