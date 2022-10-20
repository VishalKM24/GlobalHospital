using GlobalTeleHospital.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;
using GlobalTeleHospital.BL;

namespace GlobalTeleHospital.Models.Data
{
    public class ClinicDbRepo : IClinicRepo
    {
        private ClinicDbContext db = new ClinicDbContext();
        public string CreateClinic(ClinicServiceDTO clinicdto)
        {
            Clinic cln;
            cln = Logic.ClinicServiceDtoToClinic(clinicdto);

            if (cln == null)
                return " ";
            db.Clinics.Add(cln);
            db.SaveChanges();

            return "Created";
        }

        public List<Clinic> GetClinics()
        {
            return db.Clinics.ToList();
        }

        public void UpdateClinic(Clinic clinic)
        {
            db.Entry(clinic).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void CreateService(Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();
        }

        public void DeleteService(string serviceId)
        {
            Service sr = db.Services.Find(serviceId);
            if (sr == null)
                return;
            db.Services.Remove(sr);
        }

        public void UpdateService(Service service)
        {
            db.Entry(service).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public Service GetService(string id)
        {
            Service ser = db.Services.Find(id);
            if (ser == null)
                return null;
            return ser;
        }

        public List<Service> GetServices()
        {
            return db.Services.ToList();
        }

        public Clinic GetClinic(string id)
        {
            Clinic cr = db.Clinics.Find(id);
            if (cr == null)
                return null;
            return cr;
        }
    }
}