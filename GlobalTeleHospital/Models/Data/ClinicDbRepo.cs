using GlobalTeleHospital.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace GlobalTeleHospital.Models.Data
{
    public class ClinicDbRepo
    {
        private ClinicDbContext db = new ClinicDbContext();
        public void CreateClinic(ClinicDTO clinicdto)
        {
            Clinic cln = new Clinic();


            cln.ClinicId = clinicdto.ClinicId;
            cln.ClinicName = clinicdto.ClinicName;
            cln.StreetAddress = clinicdto.StreetAddress;
            cln.BussinessName = clinicdto.BussinessName;
            cln.City = clinicdto.City;
            cln.Country = clinicdto.Country;
            cln.ZipCode = clinicdto.ZipCode;
            cln.Latitude = clinicdto.Latitude;
            cln.Longitude = clinicdto.Longitude;
            cln.DateCreated = clinicdto.DateCreated;


            ClinicService sr = new ClinicService();
            foreach (var item in clinicdto.ClinicDto)
            {
                sr.IsActive = item.Value;
                sr.ServiceId = item.Key;
                sr.ClinicId = clinicdto.ClinicId;

                db.ClinicServices.Add(sr);
            }

            db.Clinics.Add(cln);
            db.SaveChanges();
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