﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Project1403.Models
{
    public class Project
    {
        //Project Attributs
        public int projectID { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Location")]
        public string location { get; set; }

        [DisplayName("Supervisor ID")]
        public int supervisor { get; set; }
    }
}