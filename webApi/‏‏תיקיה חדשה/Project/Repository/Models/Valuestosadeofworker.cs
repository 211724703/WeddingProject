﻿using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Valuestosadeofworker
    {
        public int Valuestosadeofworkerid { get; set; }
        public int Workerid { get; set; }
        public int Sadeid { get; set; }
        public string Value { get; set; }

        public Sadottype Sade { get; set; }
        public Workers Worker { get; set; }
    }
}
