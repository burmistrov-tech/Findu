﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<LostsItems> LostsItems { get; set; }
        public DbSet<Statuses> Statuses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
