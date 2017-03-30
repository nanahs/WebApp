﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using SapientGuardian.MySql.Data.EntityFrameworkCore;

namespace WebApp.Contexts
{
    public class MySqlContext : DbContext
    {

        public MySqlContext(DbContextOptions<MySqlContext> options) :base (options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Rso> Rso { get; set; }
        public DbSet<RsoMembership> RsoMembers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().ToTable("Categories").HasKey(x => x.CategoryId);
            builder.Entity<Event>().ToTable("Events").HasKey(x => x.EventId);
            builder.Entity<UserType>().ToTable("UserTypes").HasKey(x => x.UserTypeId);

            builder.Entity<User>().ToTable("Users").HasKey(x => x.UserId);

            builder.Entity<Rso>().ToTable("Rsos").HasKey(x => x.RsoId);

            var mems = builder.Entity<RsoMembership>().HasOne(x => x.rso).WithMany(s => s.rsoMem);


            //builder.Entity<RsoMember>()
            //.HasRequired(e => e.User)
            //.WithMany(e => e.Model1s)
            //.HasForeignKey(e => new { e.fk_one, e.fk_two })
            //.WillCascadeOnDelete(false);
        }
        
    }
}
