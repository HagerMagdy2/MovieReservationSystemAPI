using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class ResevationDetails
    {
        public int id { get; set; }
        [ForeignKey("reservation")]
        public int reservation_id { get; set; }
        public virtual Reservation? reservation { get; set; }
        [ForeignKey("seat")]
        public int seat_id { get; set; }
        public virtual Seat? seat { get; set; }
        //[ForeignKey("showTime")]
        //public int showtime_id { get; set; }
        //public virtual ShowTime? showTime { get; set; }

    }
}
