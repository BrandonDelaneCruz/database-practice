﻿using DatabasePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePractice.Data
{
    public class DataContext : DbContext
    {
        // DbSets<> go here!
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Do not change this value. It reads the assembly and sets the name to the project name.
                var myDatabaseName = typeof(Program).Assembly.GetName().Name;
                optionsBuilder.UseSqlServer($"Server=localhost;Database={myDatabaseName};Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }
    }
}
