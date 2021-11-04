﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolarEclipse.Models;

namespace SolarEclipse.Data
{
    public class SolarEclipseContext : DbContext
    {
        public SolarEclipseContext (DbContextOptions<SolarEclipseContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MusicSub> MusicSubs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<MusicSub>().ToTable("MusicSub");
        }


    }
}
