using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesService.Services;
using AirlinesService.Models;

namespace AirlinesService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirLineController : ControllerBase
    {
        flightBookingContext _airLineService;
        public AirLineController(flightBookingContext airLineService)
        {
            _airLineService = airLineService;
        }

        [HttpGet("FindAll")]
        public List<AirLine> FindAllAirlines()
        {
            return _airLineService.AirLines.ToList();
        }

        //[HttpPost]
        //public void AddNewAirLine(AirLine airLine)
        //{
        //    _airLineService.AddNewAirline(airLine);
        //}

        //[HttpPut]
        //public void EditAirLine(int id)
        //{
        //    _airLineService.EditAirline(id);
        //}

        //[HttpDelete]
        //public void DeleteAirLine(int id)
        //{
        //    _airLineService.DeleteAirline(id);
        //}
    }
}
