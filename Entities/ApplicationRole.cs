﻿using System;
using Microsoft.AspNetCore.Identity;

namespace BookAPI.Entities
{
    public class ApplicationRole : IdentityRole
    {
        //public string Student { get; set; }
        //public string Admin { get; set; }
        //public string Lecturer { get; set; }
        public string RoleName { get; set; }
    }
}
