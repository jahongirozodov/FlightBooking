using FlightBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightBooking.Data.Contexts;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Seat> Seats { get; set; }  
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        modelBuilder.Entity<Seat>()
            .HasOne(x => x.Flight)
            .WithMany()
            .HasForeignKey(x => x.FlightId);

        modelBuilder.Entity<Ticket>()
            .HasOne(x=> x.Flight)
            .WithMany()
            .HasForeignKey(x => x.FlightId);

        modelBuilder.Entity<Ticket>()
            .HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);
    }
}
