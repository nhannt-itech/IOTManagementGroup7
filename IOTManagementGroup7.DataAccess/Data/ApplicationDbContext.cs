﻿using IOTManagementGroup7.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOTManagementGroup7.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Light> Lights { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Camera> Cameras { get; set; }


    }
}
