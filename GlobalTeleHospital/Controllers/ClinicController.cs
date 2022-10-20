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
        private IClinicRepo repo = new ClinicDbRepo();

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
        public IHttpActionResult PostClinicDto(ClinicServiceDTO clinic)
        {
            // string val = "";
            if (!ModelState.IsValid)
                return NotFound();
            try
            {
                repo.CreateClinic(clinic);
            }
            catch (Exception exe)
            {
                return BadRequest(exe.Message);
            }
            return Ok(clinic);
        }

        [HttpPut]
        [Route("api/clinic")]
        public IHttpActionResult PutClinic(Clinic clinic)
        {
            try
            {
                if (!ModelState.IsValid)
                    return NotFound();
                repo.UpdateClinic(clinic);
                return Ok(clinic);
            }
            catch (Exception exe)
            {
                return BadRequest(exe.Message);
            }
        }

        [HttpPut]
        [Route("api/service")]
        public IHttpActionResult PutService(Service service)
        {
            if (!ModelState.IsValid)
                return NotFound();

            repo.UpdateService(service);
            return Ok(service);
        }
    }
}
