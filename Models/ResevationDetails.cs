using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class ResevationDetails
    {
        public int Id { get; set; }
        [ForeignKey("reservation")]
        public int ReservationId { get; set; }
        public virtual Reservation? reservation { get; set; }
        [ForeignKey("seat")]
        public int SeatId { get; set; }
        public virtual Seat seat { get; set; }
        [ForeignKey("showTime")]
        public int ShowTimeId { get; set; }
        public virtual ShowTime? showTime { get; set; }

    }
}
