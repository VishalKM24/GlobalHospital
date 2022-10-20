using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalTeleHospitalCS.Models.Entity
{
    public class Clinic
    {
        [Key]
        public string ClinicId { get; set; }
        [MaxLength(30)]
        [Required]
        public string ClinicName { get; set; }
        [Required]
        [MaxLength(50)]
        public string BussinessName { get; set; }
        [Required]
        [MaxLength(50)]
        public string StreetAddress { get; set; }
        [MaxLength(30)]
        [Required]
        public string City { get; set; }
        [MaxLength(30)]
        [Required]
        public string Country { get; set; }
        [MaxLength(11)]
        [Required]
        public string ZipCode { get; set; }
        [MaxLength(15)]
        public string Latitude { get; set; }
        [MaxLength(15)]
        public string Longitude { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public virtual ICollection<ClinicService> ClinicServices { get; set; }
    }
}