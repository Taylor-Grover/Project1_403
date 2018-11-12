﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1403.Models
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string jobType { get; set; }
        public string subcontractor { get; set; }
        public string location { get; set; }
        public bool isClockedIn { get; set; }
        public bool isClockedOut { get; set; }
        public DateTime timeIN { get; set; }
        public DateTime timeOUT { get; set; }
    }
}