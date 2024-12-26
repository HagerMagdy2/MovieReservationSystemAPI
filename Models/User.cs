

using Microsoft.AspNetCore.Identity;

namespace MovieReservationSystemAPI.Models
{
    public class User:IdentityUser
    {
        public string fullName { get; set; }
        public virtual List<Reservation> reservations { get; set; } = new List<Reservation>();
    }
}
