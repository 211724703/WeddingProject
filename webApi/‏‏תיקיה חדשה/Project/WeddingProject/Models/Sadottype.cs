using System;
using System.Collections.Generic;

namespace WeddingProject.Models
{
    public partial class Sadottype
    {
        public Sadottype()
        {
            Sadottypeofworker = new HashSet<Sadottypeofworker>();
            Valuestosadeofworker = new HashSet<Valuestosadeofworker>();
        }

        public int Sadetypeid { get; set; }
        public string Sadetypeteur { get; set; }

        public ICollection<Sadottypeofworker> Sadottypeofworker { get; set; }
        public ICollection<Valuestosadeofworker> Valuestosadeofworker { get; set; }
    }
}
