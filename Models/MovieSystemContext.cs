
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace MovieReservationSystemAPI.Models
{
    public class MovieSystemContext:DbContext
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



        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<IdentityRole>().HasData(
        //        new IdentityRole() { Name = "admin", NormalizedName = "ADMIN" },
        //        new IdentityRole() { Name = "user", NormalizedName = "USER" }
        //        );
        //}
    }
}
