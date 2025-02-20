﻿using AHRestAPI.Mappers;
using AHRestAPI.Models;
using AnimalHouseRestAPI.DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AHRestAPI.Controllers
{

    [Route("/services")]
    [ApiController]
    public class Services : ControllerBase
    {
        JsonSerializerSettings mainSettings = new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

        [HttpGet]
        [Route("/services/list/{ServiceCategid}")]
        public ActionResult<Service> ServcieListGetter(int ServiceCategid)
        {
            List<Service> services = DataBaseConnection.Context.Services.Where(x=>x.ServiceCategid == ServiceCategid).Distinct().ToList();
            if (services != null)
            {
                return Content(JsonConvert.SerializeObject(services, mainSettings));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("/services/alllist/")]
        public ActionResult<Service> AllService()
        {
            List<Service> services = DataBaseConnection.Context.Services.ToList();
            if (services != null)
            {
                var response = ServicesMapper.ConvertToServiceDTO(services);
                return Content(JsonConvert.SerializeObject(response, mainSettings));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
