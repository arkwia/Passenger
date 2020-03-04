using System;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public DriverDto GetDriver(Guid userId)
        {
            var driver = _driverRepository.Get(userId);

            return new DriverDto()
            {
                UserId = driver.UserId,
                Vehicle = driver.Vehicle,
                Routes = driver.Routes,
                DailyRoutes = driver.DailyRoutes
            };
        }
    }
}