using GlobalTeleHospitalCS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GlobalTeleHospitalCS.Models.Data
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<ClinicService> ClinicServices { get; set; }
    }
}