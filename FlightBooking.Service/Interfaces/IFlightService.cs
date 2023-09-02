using FlightBooking.Service.DTOs.Flights;

namespace FlightBooking.Service.Interfaces;

public interface IFlightService
{
    Task<FlightResultDto> CreateAsync(FlightCreationDto dto);
    Task<FlightResultDto> UpdateAsync(FlightUpdateDto dto);
    Task<FlightResultDto> DeleteAsync(long id);
    Task<FlightResultDto> GetByIdAsync(long id);
    Task<FlightResultDto> GetByNameAsync(string name);
    Task<IEnumerable<FlightResultDto>> GetAll();
}
