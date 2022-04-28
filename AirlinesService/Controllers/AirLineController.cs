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
        IAirlineService _airLineService;
        public AirLineController(IAirlineService iAirLineService)
        {
            _airLineService = iAirLineService;
        }

        [HttpGet]
        [Route("FindAll")]
        public List<AirLine> FindAllAirlines()
        {
            return _airLineService.FindAllAirlines();
        }

        [HttpPost]
        public void AddNewAirLine(AirLine airLine)
        {
            _airLineService.AddNewAirline(airLine);
        }

        [HttpPut]
        public void EditAirLine(int id)
        {
            _airLineService.EditAirline(id);
        }

        [HttpDelete]
        public void DeleteAirLine(int id)
        {
            _airLineService.DeleteAirline(id);
        }
    }
}
