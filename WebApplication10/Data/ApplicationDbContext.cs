﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JsonWebTokenWithAngularAspNetCore.Models.Entities;

namespace JsonWebTokenWithAngularAspNetCore.Data
{
    public class ApplicationDbContext:IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
            //
        }


        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
