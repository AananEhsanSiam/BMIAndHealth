using BMIAndHealth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Data {
    public class ApplicationDBContext : IdentityDbContext 
    { 
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<UserHistory> UserHistory { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<UserHistory>().HasKey(k => new { k.Id, k.UserId });
            builder.Entity<UserHistory>().Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
