using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace MovieReservationSystemAPI.Models
{
    public class MovieSystemContext:DbContext
    {
        public MovieSystemContext()
        {
            
        }
        public MovieSystemContext(DbContextOptions<MovieSystemContext> option):base(option) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "customer", NormalizedName = "CUSTOMER" }
                );
        }
    }
}
