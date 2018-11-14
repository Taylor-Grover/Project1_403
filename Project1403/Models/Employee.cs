using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Project1403.Models
{
    public class Employee
    {
        public string firstName { get; set; }

        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [DisplayName("Phone")]
        public string phone { get; set; }
        public string jobType { get; set; }
        public string subcontractor { get; set; }
        public string location { get; set; }
        public string isClockedIn { get; set; }
        public string isClockedOut { get; set; }
        public DateTime timeIN { get; set; }
        public DateTime timeOUT { get; set; }
    }
}