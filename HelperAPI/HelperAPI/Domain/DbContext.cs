using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HelperAPI.Domain.Entities;

namespace HelperAPI.Domain
{
    public class DbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Equipment> equipments { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<ServiceItem> serviceItems { get; set; }
        public DbSet<Worker> workers { get; set; }
        public DbSet<Mission> missions  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        
    }
}
