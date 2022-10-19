using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalTeleHospital.Models.Entity
{
    public class ClinicService
    {
        public bool IsActive { get; set; }
        public string ServiceId { get; set; }
        public string ClinicId { get; set; }
    }
}