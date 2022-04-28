using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesService.Models;

namespace AirlinesService.Services
{
    public interface IAirlineService
    {
        public List<AirLine> FindAllAirlines();
        public void AddNewAirline(AirLine airLine);
        public void DeleteAirline(int id);
        public void EditAirline(int id);
    }
}
