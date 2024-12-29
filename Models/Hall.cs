using System.ComponentModel.DataAnnotations;

namespace MovieReservationSystemAPI.Models
{
    public class Hall
    {
        public int id { get; set; }
        public string name { get; set; }
        public int NumberOfSeats { get; set; }
        public virtual List<Seat> Seats { get;  set; }=new List<Seat>();
        public virtual List<ShowTime> Shows { get;  set; }=new List<ShowTime>();
    }
}
