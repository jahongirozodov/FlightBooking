using FlightBooking.Service.DTOs.Bookings;

namespace FlightBooking.Service.Interfaces;

public interface IBookingService
{
    Task<BookingResultDto> Create(BookingCreationDto dto);
    Task<BookingResultDto> Update(BookingCreationDto dto);
    Task<bool> Delete(long id);
    Task<BookingResultDto> GetByIdAsync(long id);
    Task<IEnumerable<BookingResultDto>> GetAllAsync();
}
