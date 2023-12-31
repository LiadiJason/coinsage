﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoinsAge.Areas.Identity.Data;
using CoinsAge.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoinsAge.Data
{
    public class CoinsAge1Context : IdentityDbContext<CoinsAge1User>
    {
        public CoinsAge1Context(DbContextOptions<CoinsAge1Context> options)
            : base(options)
        {
        }

        public CoinsAge1Context()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<News> News { get; set; }
        public DbSet<TrendingNews> TrendingNews { get; set; }
        public DbSet<PopularNews> PopularNews { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
