using FlightBooking.Service.DTOs;

namespace FlightBooking.Service.Interfaces;

public interface IUserService
{
    Task<UserResultDto> RegisterAsync(UserRegisterDto dto);
    Task<bool> LoginAsync(UserLoginDto dto);
    Task<UserResultDto> UpdateAsync(UserUpdateDto dto);
    Task<bool> DeleteAsync(long Id);
    IEnumerable<UserResultDto> GetAll();
    Task<UserResultDto> GetAsync(long Id);
}
