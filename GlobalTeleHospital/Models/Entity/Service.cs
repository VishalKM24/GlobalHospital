using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalTeleHospital.Models.Entity
{
    public class Service
    {
        [Key]
        public string ServiceId { get; set; }
        [MaxLength(30)]
        public string ServiceName { get; set; }
        [MaxLength(30)]
        public string SeviceCode { get; set; }
        [MaxLength(200)]
        public string ServiceDescription { get; set; }
        public float AvgPrice { get; set; }
    }
}