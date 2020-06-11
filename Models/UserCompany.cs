﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Global_Intern.Models
{
    public class UserCompany
    {
        public int UserCompanyId { get; set; }
        public string UserCompanyName { get; set; }
        public string UserCompanyType { get; set; }
        public string UserCompanyInfo { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
