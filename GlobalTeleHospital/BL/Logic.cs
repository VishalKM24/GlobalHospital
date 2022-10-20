using AutoMapper;
using GlobalTeleHospital.Models.Entity;
using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalTeleHospital.BL
{
    public class Logic
    {
        public static Clinic ClinicServiceDtoToClinic(ClinicServiceDTO clinicDto)
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<ClinicServiceDTO, Clinic>();

            //});
            ////Using automapper
            //var mapper = new Mapper(config);
            //var clinic = mapper.Map<Clinic>(clinicDto);

            Clinic clinic = new Clinic();
            clinic.ClinicId = clinicDto.ClinicId;
            clinic.ClinicName = clinicDto.ClinicName;
            clinic.StreetAddress = clinicDto.StreetAddress;
            clinic.BussinessName = clinicDto.BussinessName;
            clinic.City = clinicDto.City;
            clinic.Country = clinicDto.Country;
            clinic.ZipCode = clinicDto.ZipCode;
            clinic.Latitude = clinicDto.Latitude;
            clinic.Longitude = clinicDto.Longitude;
            clinic.DateCreated = clinicDto.DateCreated;


            List<ClinicService> csl = new List<ClinicService>();
            foreach (var item in clinicDto.ClinicDto)
            {
                ClinicService cs = new ClinicService();
                cs.IsActive = true;
                cs.ServiceId = item.Key;
                cs.ClinicId = clinic.ClinicId;
                cs.AvgPrice = item.Value;

                csl.Add(cs);
            }

            clinic.clinicservice = csl;

            if (clinic.clinicservice.Count < 1) 
                return null;


            foreach (var service in clinic.clinicservice)
            {
                if (service.AvgPrice > 250) 
                    return null;
            }

            return clinic;
        }

        

        
    }
}