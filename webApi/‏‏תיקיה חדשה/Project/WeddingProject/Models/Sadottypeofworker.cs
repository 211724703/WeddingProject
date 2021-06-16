using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Sadottypeofworker
    {
        public int Sadeid { get; set; }
        public string Sadename { get; set; }
        public int Typeid { get; set; }
        public int Sadetypeid { get; set; }

        public Sadottype Sadetype { get; set; }
        public Typeofworker Type { get; set; }
    }
}
