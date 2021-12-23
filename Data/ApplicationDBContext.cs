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
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
        }
    }
}
