using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalTeleHospital.Models.Entity
{
    public class ClinicDTO
    {
        public Dictionary<string, bool> ClinicDto { get; set; }
        public string ClinicId { get; set; }
        public string ClinicName { get; set; }
        public string BussinessName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreated { get; set; }
    }
}