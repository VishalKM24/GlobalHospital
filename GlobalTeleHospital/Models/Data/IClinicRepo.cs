using GlobalTeleHospital.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTeleHospital.Models.Data
{
    public interface IClinicRepo
    {
        string CreateClinic(ClinicServiceDTO clinicdto);
        List<Clinic> GetClinics();
        void UpdateClinic(Clinic clinic);
        void CreateService(Service service);
        void DeleteService(string serviceId);
        void UpdateService(Service service);
        Service GetService(string id);
        List<Service> GetServices();
        Clinic GetClinic(string id);
    }
}
