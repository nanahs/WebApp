using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Contexts
{
    public class MySqlContext : DbContext
    {

        public MySqlContext(DbContextOptions<MySqlContext> options) :base (options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users").HasKey(x => x.UserId);
            builder.Entity<UserType>().ToTable("UserType").HasKey(x => x.UserTypeId);
        }
        
    }
}
