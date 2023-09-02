using AutoMapper;
using FlightBooking.Domain.Entities;
using FlightBooking.Service.DTOs;
using FlightBooking.Service.DTOs.Bookings;
using FlightBooking.Service.DTOs.Flights;
using FlightBooking.Service.DTOs.Payments;
using FlightBooking.Service.DTOs.Seats;
using FlightBooking.Service.DTOs.Tickets;

namespace FlightBooking.Service.Helpers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //User
        CreateMap<UserRegisterDto, User>().ReverseMap().ForMember(x => x.Password, x => x.MapFrom("PasswordHash"));
        CreateMap<UserUpdateDto, User>().ReverseMap().ForMember(x => x.Password, x => x.MapFrom("PasswordHash"));
        CreateMap<UserLoginDto, User>().ReverseMap();
        CreateMap<UserResultDto, User>().ReverseMap();
        
        //Flight
        CreateMap<Flight,FlightCreationDto>().ReverseMap();
        CreateMap<Flight,FlightResultDto>().ReverseMap();
        CreateMap<Flight,FlightUpdateDto>().ReverseMap();

        //Booking
        CreateMap<Booking,BookingCreationDto>().ReverseMap();
        CreateMap<Booking,BookingResultDto>().ReverseMap();
        CreateMap<Booking,BookingUpdateDto>().ReverseMap();

        //Seat
        CreateMap<SeatCreationDto,Seat>().ReverseMap();
        CreateMap<SeatUpdateDto,Seat>().ReverseMap();
        CreateMap<SeatResultDto,Seat>().ReverseMap();

        //Ticket
        CreateMap<Ticket,TicketCreationDto>().ReverseMap();
        CreateMap<Ticket,TicketUpdateDto>().ReverseMap();
        CreateMap<Ticket,TicketResultDto>().ReverseMap();

        //Payment
        CreateMap<Payment,PaymentCreationDto>().ReverseMap();
        CreateMap<Payment,PaymentUpdateDto>().ReverseMap();
        CreateMap<Payment,PaymentResultDto>().ReverseMap();
    }
}
