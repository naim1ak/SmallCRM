﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmallCRM.Admin.Models
{
    public class LeadStatusViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}