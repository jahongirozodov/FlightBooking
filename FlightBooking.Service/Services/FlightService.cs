using AutoMapper;
using FlightBooking.Data.Repository;
using FlightBooking.Domain.Entities;
using FlightBooking.Service.DTOs.Flights;
using FlightBooking.Service.Interfaces;

namespace FlightBooking.Service.Services;

public class FlightService : IFlightService
{
    private readonly IMapper mapper;
    private Repository<Flight> repository;
    public FlightService(IMapper mapper, Repository<Flight> repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public Task<FlightResultDto> CreateAsync(FlightCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<FlightResultDto> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<FlightResultDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<FlightResultDto> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<FlightResultDto> GetByNameAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<FlightResultDto> UpdateAsync(FlightUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
