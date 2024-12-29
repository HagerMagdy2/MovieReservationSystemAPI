using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class Reservation
    {
        
        public int id { get; set; }
        [ForeignKey("user")]
        public string user_id { get; set; }
        public virtual User user { get; set; }
        [ForeignKey("showTime")]
        public int showtime_id { get; set; }
        public virtual ShowTime showTime { get; set; }
        public DateTime ReservationDate { get; set; }
        public virtual List<ResevationDetails> ReservationDetails { get; set; } = new List<ResevationDetails>();


    }
}
