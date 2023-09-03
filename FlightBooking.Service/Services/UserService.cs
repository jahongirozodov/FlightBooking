using AutoMapper;
using FlightBooking.Data.IRepository;
using FlightBooking.Domain.Entities;
using FlightBooking.Service.DTOs;
using FlightBooking.Service.Exceptions;
using FlightBooking.Service.Interfaces;
using FlightBooking.Service.Security;

namespace FlightBooking.Service.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> repository;
    private IMapper mapper;
    public UserService(IRepository<User> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }
    public Task<bool> DeleteAsync(long Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UserResultDto> GetAll()
    {
        var users = repository.GetAll();
        return mapper.Map<IEnumerable<UserResultDto>>(users);
    }

    public async Task<UserResultDto> GetAsync(long Id)
    {
        var user = await repository.GetAsync(u => u.Id.Equals(Id));
        if (user is null)
            throw new NotFoundException("This user is not found");

        return mapper.Map<UserResultDto>(user);
    }

    public async Task<bool> LoginAsync(UserLoginDto dto)
    {
        var existUser = await repository.GetAsync(x => x.Email.Equals(dto.Email));
        if (existUser is null)
            throw new NotFoundException("This user is not found");

        var result = PasswordHash.Verify(dto.Password, existUser.PasswordHash, existUser.Salt);
        if (result is false)
            throw new IncorrectException("Email or Password incorrect");

        return result;
    }

    public async Task<UserResultDto> RegisterAsync(UserRegisterDto dto)
    {
        var existUser = await repository.GetAsync(x => x.Email.Equals(dto.Email));
        if (existUser is not null)
            throw new AlreadyExistException("This user is already exist!");

        var user = mapper.Map<User>(dto);
        (user.Salt, user.PasswordHash) = PasswordHash.Hasher(dto.Password);

        await repository.AddAsync(user);
        await repository.SaveAsync();

        return mapper.Map<UserResultDto>(user);
    }

    public Task<UserResultDto> UpdateAsync(UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
