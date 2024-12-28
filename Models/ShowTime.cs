using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class ShowTime
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("movie")]
        public int movie_id { get; set; }
        public virtual Movie? movie { get; set; }
        [ForeignKey("hall")]
        public int hall_id { get; set; }
        public virtual Hall? hall { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual List<Reservation> Reservations { get; set; }=new List<Reservation>();
       // public virtual List<ResevationDetails> ReseurationDetails { get; set;} =new List<ResevationDetails>();
       
    }
}
