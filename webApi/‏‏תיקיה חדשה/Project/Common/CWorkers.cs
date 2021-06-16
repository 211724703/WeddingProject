using System;
using System.Collections.Generic;

namespace Common
{
    public partial class CWorkers
    {


        public int Workerid { get; set; }
        public string Nameworker { get; set; }
        public int Selfphone { get; set; }
        public string Description { get; set; }
        public string Mailworker { get; set; }
        public int Typeid { get; set; }
        public string price { get; set; }
        public string Image { get; set; }
        public List<string> Values { get; set; }
        public string aria { get; set; }
        public string janner { get; set; }
        public string category { get; set; }
        public List<KeyValuePair<string, string>> ExtraValues {get; set;}
        //public Typeofworker Type { get; set; }
        //public ICollection<Feedback> Feedback { get; set; }
        //public ICollection<Valuestosadeofworker> Valuestosadeofworker { get; set; }
        //public ICollection<Workertowedding> Workertowedding { get; set; }
    }
}
