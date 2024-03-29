﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BerryApi.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Column(TypeName ="nvarchar(150)")]
        public string Firstname { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Lastname { get; set; }
    }
}
