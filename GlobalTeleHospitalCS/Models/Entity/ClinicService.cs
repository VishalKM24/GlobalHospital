using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GlobalTeleHospitalCS.Models.Entity
{
    public class ClinicService
    {
        [Key, Column(Order = 0)]
        public string ClinicId { get; set; }
        [Key, Column(Order = 1)] 
        public string ServiceId { get; set; }

        public virtual Clinic Clinic { get; set; }
        public virtual Service Service { get; set; }
        public bool IsActive { get; set; }
    }
}