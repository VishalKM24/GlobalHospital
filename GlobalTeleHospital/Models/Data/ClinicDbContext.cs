using GlobalTeleHospital.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GlobalTeleHospital.Models.Data
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext(): base("name=DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClinicService>().HasKey(s => new { s.ServiceId, s.ClinicId });
        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ClinicService> ClinicServices { get; set; }
    }
}