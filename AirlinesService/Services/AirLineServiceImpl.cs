using AirlinesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlinesService.Services
{
    public class AirLineServiceImpl : IAirlineService
    {
        private readonly flightBookingContext _dbContext;
        public AirLineServiceImpl(flightBookingContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<AirLine> FindAllAirlines()
        {
            return _dbContext.AirLines.ToList();
        }
        public void AddNewAirline(AirLine airLine)
        {
            _dbContext.AirLines.Add(airLine);
            save();
        }

        public void DeleteAirline(int id)
        {
            var airLine = _dbContext.AirLines.Find(id);
            _dbContext.AirLines.Remove(airLine);
            save();
        }

        public void EditAirline(int id)
        {
            throw new NotImplementedException();
        }       

        public void save()
        {
            _dbContext.SaveChanges();
        }
    }
}
