

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MovieReservationSystemAPI.Models
{
    public class MovieSystemContext:IdentityDbContext
    {
        public MovieSystemContext()
        {
            
        }
       public MovieSystemContext(DbContextOptions<MovieSystemContext> Option) : base(Option) { }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ResevationDetails> ResevationDetail { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<ShowTime> ShowsTime { get; set; }
        public virtual DbSet<Types> Types { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ResevationDetails>().HasKey("ReservationId", "SeatId");
            builder.Entity<ResevationDetails>()
        .HasOne(rd => rd.reservation)
        .WithMany()
        .HasForeignKey(rd => rd.ReservationId)
        .OnDelete(DeleteBehavior.Cascade); // Keep Cascade for Reservation

            builder.Entity<ResevationDetails>()
                .HasOne(rd => rd.seat)
                .WithMany()
                .HasForeignKey(rd => rd.SeatId)
                .OnDelete(DeleteBehavior.Restrict); // Change to Restrict for Seat

            builder.Entity<ResevationDetails>()
                .HasOne(rd => rd.showTime)
                .WithMany()
                .HasForeignKey(rd => rd.ShowTimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "user", NormalizedName = "USER" }
                );
        }
    }
}
