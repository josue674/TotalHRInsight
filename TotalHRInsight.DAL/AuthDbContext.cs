﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalHRInsight.DAL
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext() { }

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "server=127.0.0.1;database=Prueba;User=root;Password=123456789";
            var connectionString = "server=viaduct.proxy.rlwy.net;database=railway;port=32013;User=root;Password=hVYCFgtlWkqHIiqyhWjcOCCNVhHxELRS";
            //var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
