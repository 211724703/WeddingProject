using System;
using System.Collections.Generic;

namespace Common
{
    public partial class CSadottypeofworker
    {
        public int Sadeid { get; set; }
        public string Sadename { get; set; }
        public int Typeid { get; set; }
        public int Sadetypeid { get; set; }

        public CSadottype Sadetype { get; set; }
        public CTypeofworker Type { get; set; }
    }
}
