using System;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public interface IDriverService
    {
         DriverDto GetDriver(Guid userId);
    }
}