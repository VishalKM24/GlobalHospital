using GlobalTeleHospital.Models.Data;
using GlobalTeleHospital.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlobalTeleHospital.Controllers
{
    public class ClinicController : ApiController
    {
        private ClinicDbRepo repo = new ClinicDbRepo();

        [HttpGet]
        [Route("api/clinic")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetClinics());
        }

        [HttpGet]
        [Route("api/clinic/{id}")]
        public IHttpActionResult GetClinic(string id)
        {
            var clinic = repo.GetClinic(id);

            if (clinic == null)
            {
                return NotFound();
            }
            return Ok(clinic);
        }

        [HttpGet]
        [Route("api/service/{id}")]
        public IHttpActionResult GetService(string id)
        {
            var service = repo.GetService(id);

            if (service == null)
            {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("api/service")]
        public IHttpActionResult GetServices()
        {
            var service = repo.GetServices();

            if (service == null)
            {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpPost]
        [Route("api/service")]
        public IHttpActionResult PostService(Service service)
        {
            if (!ModelState.IsValid)
                return NotFound();
            repo.CreateService(service);

            return Ok(service);
        }

        [HttpPost]
        [Route("api/clinic")]
        public IHttpActionResult PostClinicDto(ClinicDTO clinic)
        {
            if (!ModelState.IsValid)
                return NotFound();
            repo.CreateClinic(clinic);

            return Ok(clinic);
        }

    }
}
